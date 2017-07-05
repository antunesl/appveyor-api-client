using AppVeyorClient.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AppVeyorClient.Clients
{
    /// <summary>
    /// 
    /// </summary>
    public class BuildClient : BaseClient
    {
        public BuildClient(ILogger<BuildClient> logger, string baseUri, string accessToken) : base(logger, baseUri, accessToken)
        {
        }


        /// <summary>
        /// Start a build from the last commit
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Build> StartBuildFromLastCommit(StartBuildInfo request)
        {
            var url = $"api/builds";
            var response = await PostHttp<Build>(url, request);
            return response.Data;
        }


        /// <summary>
        /// Cancel a build
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="projectSlug"></param>
        /// <param name="buildVersion"></param>
        /// <returns></returns>
        public async Task<ApiResponse> CancelBuild(string accountName, string projectSlug, string buildVersion)
        {
            if (accountName == null)
                throw new ArgumentNullException(nameof(accountName), "Missing required parameter 'accountName' when calling BuildClient->CancelBuild");

            if (projectSlug == null)
                throw new ArgumentNullException(nameof(accountName), "Missing required parameter 'projectSlug' when calling BuildClient->CancelBuild");

            if (buildVersion == null)
                throw new ArgumentNullException(nameof(accountName), "Missing required parameter 'buildVersion' when calling BuildClient->CancelBuild");

            var url = $"api/builds/{accountName}/{projectSlug}/{buildVersion}";

            return await DeleteHttp(url);
        }


        /// <summary>
        /// Download build log
        /// </summary>
        /// <param name="jobId"></param>
        /// <returns></returns>
        public async Task<ApiResponse<string>> GetBuildLog(string jobId)
        {
            if (jobId == null)
                throw new ArgumentNullException(nameof(jobId), "Missing required parameter 'jobId' when calling BuildApi->GetBuildLog");

            var url = $"/api/buildjobs/{jobId}/log";

            return await GetHttp<string>(url);
        }
    }
}
