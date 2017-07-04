using AppVeyorClient.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppVeyorClient.Clients
{
    public class BaseClient
    {
        protected readonly HttpClient _client;

        private string _accessToken;


        public BaseClient(string baseUri, string accessToken)
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
                SetInitialToken();

                var response = await _client.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();

                if (typeof(T) == typeof(string))
                {
                    return new ApiResponse<T>((int)response.StatusCode, (T)(object)content);
                }

                return new ApiResponse<T>((int)response.StatusCode, JsonConvert.DeserializeObject<T>(content));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected async Task<ApiResponse> DeleteHttp(string url)
        {
            SetInitialToken();

            var response = await _client.DeleteAsync(url);

            return new ApiResponse((int)response.StatusCode);
        }

        protected async Task<ApiResponse<T>> PostHttp<T>(string url, object data)
        {
            SetInitialToken();

            var response = await _client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json"));

            var content = await response.Content.ReadAsStringAsync();

            return new ApiResponse<T>((int)response.StatusCode, JsonConvert.DeserializeObject<T>(content));
        }


        private void SetInitialToken()
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Authorization = JwtAuthHeader.GetHeader(_accessToken);
            return;
        }
    }


    public class JwtAuthHeader
    {
        public static AuthenticationHeaderValue GetHeader(string accessToken)
        {
            return new AuthenticationHeaderValue("Bearer", accessToken);
        }
    }
}
