using System;
using System.Threading.Tasks;
using Xunit;

namespace AppVeyorClient.Tests
{
    public class BuildTests
    {
        private const string _apiKey = "x0kenclqx58icumvcdl0";
        private const string _accountName = "antunesl";
        private const string _projectName = "splitter";

        private const string existingJobId = "vgjkgdskx5ot8g0d";

        [Fact]
        public async Task Get_Build_Log()
        {


            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Builds.GetBuildLog(existingJobId);
            Assert.Equal(200, result.StatusCode);
        }

        [Fact]
        public async Task Get_Build_Log_From_Non_Existing_JobId()
        {
            var jobId = $"{existingJobId}_{Guid.NewGuid().ToString()}";

            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Builds.GetBuildLog(jobId);
            Assert.Equal(404, result.StatusCode);
        }


        [Fact]
        public async Task StartBuild_From_Last_Commit_And_If_OK_Cancel_Build()
        {
            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Builds.StartBuildFromLastCommit(new Model.StartBuildInfo(_accountName, _projectName));
            Assert.NotNull(result);

            var cancelResult = await api.Builds.CancelBuild(_accountName, _projectName, result.Version);
            Assert.Equal(204, cancelResult.StatusCode);
        }
    }
}
