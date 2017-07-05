using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppVeyorClient.Tests
{
    public class ApiOptionsTests
    {
        private const string _apiKey = "x0kenclqx58icumvcdl0";
        private const string _accountName = "antunesl";
        private const string _projectName = "splitter";

        private const string existingJobId = "vgjkgdskx5ot8g0d";

        [Fact]
        public async Task ApiOptions_Are_Persisted()
        {
            var customBaseUri = "http://some.appveyor.server.com";
            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions
            {
                BaseUri = customBaseUri,
                ApiKey = _apiKey
            });

            Assert.Equal(_apiKey, api.ApiKey);
            Assert.Equal(customBaseUri, api.BaseUri);
        }
    }
}
