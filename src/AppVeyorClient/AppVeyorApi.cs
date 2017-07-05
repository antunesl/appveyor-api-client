using AppVeyorClient.Clients;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AppVeyorClient
{
    public class AppVeyorApi
    {
        private readonly AppVeyorApiOptions _options;
        private readonly ILoggerFactory _loggerFactory;
        private readonly string _defaultBaseUri = "https://ci.appveyor.com";

        private ProjectClient _projects;
        private BuildClient _builds;
        private DeploymentClient _deployments;
        

        // Options available to get
        public AppVeyorApiOptions Options => _options;
        public string ApiKey => _options.ApiKey;
        public string BaseUri => _options.BaseUri;


        #region Clients

        /// <summary>
        /// 
        /// </summary>
        public ProjectClient Projects => _projects ?? (_projects = new ProjectClient(_loggerFactory.CreateLogger<ProjectClient>(), _options.BaseUri, _options.ApiKey));

        /// <summary>
        /// 
        /// </summary>
        public BuildClient Builds => _builds ?? (_builds = new BuildClient(_loggerFactory.CreateLogger<BuildClient>(), _options.BaseUri, _options.ApiKey));

        /// <summary>
        /// 
        /// </summary>
        public DeploymentClient Deployments => _deployments ?? (_deployments = new DeploymentClient(_loggerFactory.CreateLogger<DeploymentClient>(), _options.BaseUri, _options.ApiKey));

        #endregion


        public AppVeyorApi(AppVeyorApiOptions options) : this(null, options)
        {
        }

        public AppVeyorApi(ILoggerFactory loggerFactory, AppVeyorApiOptions options)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));

            if (string.IsNullOrWhiteSpace(_options.BaseUri))
                _options.BaseUri = _defaultBaseUri;

            _loggerFactory = loggerFactory ?? new LoggerFactory();
        }
    }
}
