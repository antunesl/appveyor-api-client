using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace AppVeyorClient.Model
{
    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnvironmentProvider
    {

        /// <summary>
        /// Enum Agent for "Agent"
        /// </summary>
        [EnumMember(Value = "Agent")]
        Agent,

        /// <summary>
        /// Enum AzureBlob for "AzureBlob"
        /// </summary>
        [EnumMember(Value = "AzureBlob")]
        AzureBlob,

        /// <summary>
        /// Enum AzureCS for "AzureCS"
        /// </summary>
        [EnumMember(Value = "AzureCS")]
        AzureCS,

        /// <summary>
        /// Enum AzureWebJob for "AzureWebJob"
        /// </summary>
        [EnumMember(Value = "AzureWebJob")]
        AzureWebJob,

        /// <summary>
        /// Enum BinTray for "BinTray"
        /// </summary>
        [EnumMember(Value = "BinTray")]
        BinTray,

        /// <summary>
        /// Enum FTP for "FTP"
        /// </summary>
        [EnumMember(Value = "FTP")]
        FTP,

        /// <summary>
        /// Enum GitHub for "GitHub"
        /// </summary>
        [EnumMember(Value = "GitHub")]
        GitHub,

        /// <summary>
        /// Enum NuGet for "NuGet"
        /// </summary>
        [EnumMember(Value = "NuGet")]
        NuGet,

        /// <summary>
        /// Enum S3 for "S3"
        /// </summary>
        [EnumMember(Value = "S3")]
        S3,

        /// <summary>
        /// Enum SqlDatabase for "SqlDatabase"
        /// </summary>
        [EnumMember(Value = "SqlDatabase")]
        SqlDatabase,

        /// <summary>
        /// Enum WebDeploy for "WebDeploy"
        /// </summary>
        [EnumMember(Value = "WebDeploy")]
        WebDeploy,

        /// <summary>
        /// Enum Webhook for "Webhook"
        /// </summary>
        [EnumMember(Value = "Webhook")]
        Webhook
    }
}
