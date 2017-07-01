using AppVeyorClient;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AppVeyorClinet.Tests
{
    public class BuildTests
    {
        private const string _apiKey = "x0kenclqx58icumvcdl0";
        private const string _accountName = "antunesl";

        private const string existingJobId = "vgjkgdskx5ot8g0d";

        [Fact]
        public async Task Get_Build_Log()
        {


            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Builds.GetBuildLog(existingJobId);
            Assert.Equal(result.StatusCode, 200);
        }

        [Fact]
        public async Task Get_Build_Log_From_Non_Existing_JobId()
        {
            var jobId = $"{existingJobId}_{Guid.NewGuid().ToString()}";

            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Builds.GetBuildLog(jobId);
            Assert.Equal(result.StatusCode, 404);
        }
    }
}
