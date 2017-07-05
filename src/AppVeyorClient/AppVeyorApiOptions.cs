using System;

namespace AppVeyorClient
{
    /// <summary>
    /// Api Client Options.
    /// </summary>
    public class AppVeyorApiOptions
    {

        /// <summary>
        /// 
        /// </summary>
        public AppVeyorApiOptions()
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUri"></param>
        /// <param name="timeout"></param>
        public AppVeyorApiOptions(string apiKey, string baseUri = null, TimeSpan? timeout = null)
        {
            BaseUri = baseUri;
            ApiKey = apiKey;
            Timeout = timeout ?? TimeSpan.FromSeconds(100);
        }

        /// <summary>
        /// Base Uri of the AppVeyor CI to be used. The default is https://ci.appveyor.com
        /// </summary>
        public string BaseUri { get; set; }

        /// <summary>
        /// AppVeyor API Key to be used
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Timeout to be used in API calls
        /// </summary>
        public TimeSpan Timeout { get; set; }
    }
}