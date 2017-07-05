using System;

namespace AppVeyorClient
{
    public class AppVeyorApiOptions
    {
        public AppVeyorApiOptions()
        {
                
        }
        public AppVeyorApiOptions(string apiKey, string baseUri = null, TimeSpan? timeout = null)
        {
            BaseUri = baseUri;
            ApiKey = apiKey;
            Timeout = timeout ?? TimeSpan.FromSeconds(100);
        }

        public string BaseUri { get; set; }
        public string ApiKey { get; set; }
        public TimeSpan Timeout { get; set; }
    }
}