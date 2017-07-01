using AppVeyorClient.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
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
