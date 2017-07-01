using AppVeyorClient.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppVeyorClient.Clients
{
    public class ProjectClient : BaseClient
    {
        public ProjectClient(string baseUri, string accessToken) : base(baseUri, accessToken)
        {

        }


        public async Task<ApiResponse<ProjectBuild>> GetProjectLastBuild(string accountName, string projectSlug)
        {
            // verify the required parameter 'accountName' is set
            if (accountName == null)
                throw new ArgumentNullException(nameof(accountName), "Missing required parameter 'accountName' when calling ProjectClient->GetProjectLastBuild");
            // verify the required parameter 'projectSlug' is set
            if (projectSlug == null)
                throw new ArgumentNullException(nameof(projectSlug), "Missing required parameter 'projectSlug' when calling ProjectClient->GetProjectLastBuild");

            var localVarPath = $"api/projects/{accountName}/{projectSlug}";

            var result = await GetHttp<ProjectBuild>(localVarPath);

            return result;

        }



        ///// <summary>
        ///// Get project build by version
        ///// </summary>
        ///// <remarks>
        ///// 
        ///// </remarks>
        ///// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        ///// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        ///// <param name="projectSlug">Project Slug</param>
        ///// <param name="buildVersion">Build Version (&#x60;version&#x60; property of &#x60;Build&#x60;)</param>
        ///// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        public async Task<ApiResponse<ProjectBuild>> GetProjectBuildByVersion(string accountName, string projectSlug, string buildVersion)
        {
            var url = $"api/projects/{accountName}/{projectSlug}/build/{buildVersion}";

            return await GetHttp<ProjectBuild>(url);

        }


        ///// <summary>
        ///// Get project deployments
        ///// </summary>
        ///// <remarks>
        ///// 
        ///// </remarks>
        ///// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        ///// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        ///// <param name="projectSlug">Project Slug</param>
        ///// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async Task<ApiResponse<ProjectDeployments>> GetProjectDeployments(string accountName, string projectSlug)
        {

            var url = $"api/projects/{accountName}/{projectSlug}/deployments";

            return await GetHttp<ProjectDeployments>(url);

        }




        ///// <summary>
        ///// Get project history
        ///// </summary>
        ///// <remarks>
        ///// 
        ///// </remarks>
        ///// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        ///// <param name="recordsNumber">Number of results to include in the response.</param>
        ///// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        ///// <param name="projectSlug">Project Slug</param>
        ///// <param name="startBuildId">Maximum &#x60;buildId&#x60; to include in the results (exclusive). (optional)</param>
        ///// <param name="branch">Repository Branch (optional)</param>
        ///// <returns>Task of InlineResponse2005</returns>
        public async Task<ApiResponse<GetProjectHistoryResponse>> GetProjectHistory(int? recordsNumber, string accountName, string projectSlug, int? startBuildId = null, string branch = null)
        {
            var url = $"api/projects/{accountName}/{projectSlug}/history?recordsNumber={recordsNumber}";

            if (startBuildId != null)
            {
                url = url + $"&startBuildId={startBuildId}";
            }

            if (branch != null)
            {
                url = url + $"&branch={branch}";
            }


            return await GetHttp<GetProjectHistoryResponse>(url);
        }



        ///// <summary>
        ///// Get project last branch build
        ///// </summary>
        ///// <remarks>
        ///// 
        ///// </remarks>
        ///// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        ///// <param name="accountName">AppVeyor account name (&#x60;accountName&#x60; property of &#x60;UserAccount&#x60;)</param>
        ///// <param name="projectSlug">Project Slug</param>
        ///// <param name="buildBranch">Build Branch</param>
        ///// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        public async Task<ApiResponse<ProjectBuild>> GetProjectLastBuildBranch(string accountName, string projectSlug, string buildBranch)
        {
            var localVarPath = $"api/projects/{accountName}/{projectSlug}/branch/{buildBranch}";

            var result = await GetHttp<ProjectBuild>(localVarPath);

            return result;
        }





        ///// <summary>
        ///// Get projects
        ///// </summary>
        ///// <remarks>
        ///// 
        ///// </remarks>
        ///// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        ///// <returns>Task of List&lt;InlineResponse2003&gt;</returns>
        public async Task<ApiResponse<List<Project>>> GetProjects()
        {
            var localVarPath = $"api/projects/";

            var result = await GetHttp<List<Project>>(localVarPath);

            return result;


        }


    }
}
