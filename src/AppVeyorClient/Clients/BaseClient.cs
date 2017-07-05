using AppVeyorClient.Model;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppVeyorClient.Clients
{
    public class BaseClient
    {
        protected readonly ILogger _logger;
        protected readonly HttpClient _client;

        private string _accessToken;


        public ILogger Logger => _logger;


        public BaseClient(ILogger<BaseClient> logger, string baseUri, string accessToken)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(baseUri)
            };
            _accessToken = accessToken;
        }




        protected async Task<ApiResponse<T>> GetHttp<T>(string url)
        {
            try
            {
                T data;
                LogTrace($"[{nameof(GetHttp)}] HTTP GET {url}");

                SetRequestHeaders();

                var response = await _client.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();

                // if we want string type, dont deserialize content
                if (typeof(T) == typeof(string))
                {
                    data = (T)(object)content;
                }
                else
                {
                    data = JsonConvert.DeserializeObject<T>(content);
                }

                LogDebug($"[GET {url}] {(int)response.StatusCode} - {response.StatusCode}");

                return new ApiResponse<T>((int)response.StatusCode, data);
            }
            catch (Exception ex)
            {
                return HandleHttpErrors<T>(ex, url);
            }
        }

        protected async Task<ApiResponse> DeleteHttp(string url)
        {
            try
            {
                LogTrace($"[{nameof(GetHttp)}] HTTP DELETE {url}");

                SetRequestHeaders();

                var response = await _client.DeleteAsync(url);

                LogDebug($"[DELETE {url}] {(int)response.StatusCode} - {response.StatusCode}");

                return new ApiResponse((int)response.StatusCode);
            }
            catch (Exception ex)
            {
                return HandleHttpErrors(ex, url);
            }
        }

        protected async Task<ApiResponse<T>> PostHttp<T>(string url, object data)
        {
            try
            {
                LogTrace($"[{nameof(GetHttp)}] HTTP POST {url}");

                SetRequestHeaders();

                var request = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(url, request);

                LogDebug($"[POST {url}] {(int)response.StatusCode} - {response.StatusCode}");

                var content = await response.Content.ReadAsStringAsync();
                return new ApiResponse<T>((int)response.StatusCode, JsonConvert.DeserializeObject<T>(content));
            }
            catch (Exception ex)
            {
                return HandleHttpErrors<T>(ex, url);
            }
        }




        private ApiResponse HandleHttpErrors(Exception exc, string url, object data = null)
        {
            return HandleHttpErrors<object>(exc, url, data);
        }

        private ApiResponse<T> HandleHttpErrors<T>(Exception exc, string url, object data = null)
        {
            if (exc == null)
                return null;

            if (exc is TaskCanceledException)
            {
                if (!((TaskCanceledException)exc).CancellationToken.IsCancellationRequested)
                {
                    // timeout
                    var timeoutMsg = $"Timeout calling AppVeyor server on {url}";
                    LogError($"{timeoutMsg}");

                    return new ApiResponse<T>((int)HttpStatusCode.RequestTimeout, default(T)) { Timeout = true };
                }

                var errorMsg = $"Error calling AppVeyor server on {url}. See inner exception for details.";
                LogError($"{errorMsg}");
                throw new AppVeyorClientException(errorMsg, exc);
            }
            else
            {
                var errorMsg = $"Error calling AppVeyor server on {url}. See inner exception for details.";
                LogError($"{errorMsg}");
                throw new AppVeyorClientException(errorMsg, exc);
            }
        }


        #region Log Wrapper

        private void SetRequestHeaders()
        {
            var acceptContent = "application/json";

            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptContent));
            LogTrace($"Set Header: Accept {acceptContent}");

            _client.DefaultRequestHeaders.Authorization = JwtAuthHeader.GetHeader(_accessToken);
            LogTrace($"Set Authorization: {_client.DefaultRequestHeaders.Authorization.ToString()}");

            return;
        }

        private void LogDebug(string message)
        {
            if (_logger != null)
            {
                _logger.LogDebug(message);
            }
        }

        private void LogTrace(string message)
        {
            if (_logger != null)
            {
                _logger.LogTrace(message);
            }
        }

        private void LogError(string message)
        {
            if (_logger != null)
            {
                _logger.LogError(message);
            }
        }

        #endregion

    }


    public class JwtAuthHeader
    {
        public static AuthenticationHeaderValue GetHeader(string accessToken)
        {
            return new AuthenticationHeaderValue("Bearer", accessToken);
        }
    }
}
