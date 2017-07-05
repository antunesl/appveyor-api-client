using Microsoft.Extensions.Logging;

namespace AppVeyorClient.Clients
{
    public class DeploymentClient : BaseClient
    {
        public DeploymentClient(ILogger<DeploymentClient> logger, string baseUri, string accessToken) : base(logger, baseUri, accessToken)
        {
        }
    }
}
