using AppVeyorClient.Model;
using System;
using System.Threading.Tasks;

namespace AppVeyorClient.Clients
{
    public class BuildClient : BaseClient
    {
        public BuildClient(string baseUri, string accessToken) : base(baseUri, accessToken)
        {
        }

        public async Task<ApiResponse<string>> GetBuildLog(string jobId)
        {
            if (jobId == null)
                throw new ArgumentNullException(nameof(jobId), "Missing required parameter 'jobId' when calling BuildApi->GetBuildLog");

            var url = $"/api/buildjobs/{jobId}/log";


            var result = await GetHttp<string>(url);

            return result;

        }
    }
}
