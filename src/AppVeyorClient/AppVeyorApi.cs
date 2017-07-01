using AppVeyorClient.Clients;
using System;

namespace AppVeyorClient
{
    public class AppVeyorApi
    {
        private readonly string _baseUri = "https://ci.appveyor.com";
        private readonly string _accessToken;

        private ProjectClient _projects;
        private BuildClient _builds;
        private DeploymentClient _deployments;




        public ProjectClient Projects => _projects ?? (_projects = new ProjectClient(_baseUri, _accessToken));

        public BuildClient Builds => _builds ?? (_builds = new BuildClient(_baseUri, _accessToken));

        public DeploymentClient Deployments => _deployments ?? (_deployments = new DeploymentClient(_baseUri, _accessToken));







        public AppVeyorApi(AppVeyorApiOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            _accessToken = options.ApiKey;
        }
    }
}
