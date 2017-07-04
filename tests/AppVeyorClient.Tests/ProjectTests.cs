using System;
using System.Threading.Tasks;
using Xunit;

namespace AppVeyorClient.Tests
{
    public class ProjectTests
    {
        private const string _apiKey = "x0kenclqx58icumvcdl0";
        private const string _accountName = "antunesl";
        private const string _projectName = "splitter";

        [Fact]
        public async Task GetProjectLastBuild()
        {
            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Projects.GetProjectLastBuild(_accountName, _projectName);
            Assert.Equal(result.StatusCode, 200);
        }

        [Fact]
        public async Task GetProjectLastBuild_From_InexistingProject_Should_Return_Error()
        {
            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Projects.GetProjectLastBuild(_accountName, Guid.NewGuid().ToString());
            Assert.Equal(result.StatusCode, 404);
        }



        [Fact]
        public async Task GetProjectLastBuild_From_Branch()
        {
            var pageSize = 1;
            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Projects.GetProjectLastBuildBranch(_accountName, _projectName, "master");

            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Data.Project);
            Assert.NotNull(result.Data.Build);
        }



        [Fact]
        public async Task GetProjects()
        {
            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Projects.GetProjects();

            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Data);
            Assert.True(result.Data.Count > 0);
        }


        [Fact]
        public async Task GetProjectHistory()
        {
            var pageSize = 1;
            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Projects.GetProjectHistory(pageSize, _accountName, _projectName);

            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Data.Project);
            Assert.NotNull(result.Data.Builds);
            Assert.True(result.Data.Builds.Count == pageSize);
        }




        [Fact]
        public async Task GetProjectDeployments()
        {
            var pageSize = 1;
            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Projects.GetProjectDeployments(_accountName, _projectName);

            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Data.Project);
            Assert.NotNull(result.Data.Deployments);
            Assert.True(result.Data.Deployments.Count > 0);
        }




        [Fact]
        public async Task GetProjectBuild_By_Version()
        {
            AppVeyorApi api = new AppVeyorApi(new AppVeyorApiOptions { ApiKey = _apiKey });
            var result = await api.Projects.GetProjectBuildByVersion(_accountName, _projectName, "0.1.1");

            Assert.Equal(result.StatusCode, 200);
            Assert.NotNull(result.Data.Project);
            Assert.NotNull(result.Data.Build);
        }




    }
}
