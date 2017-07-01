using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace AppVeyorClient.Model
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeploymentStatus
    {

        /// <summary>
        /// Enum Cancelled for "cancelled"
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,

        /// <summary>
        /// Enum Cancelling for "cancelling"
        /// </summary>
        [EnumMember(Value = "cancelling")]
        Cancelling,

        /// <summary>
        /// Enum Failed for "failed"
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

        /// <summary>
        /// Enum Queued for "queued"
        /// </summary>
        [EnumMember(Value = "queued")]
        Queued,

        /// <summary>
        /// Enum Running for "running"
        /// </summary>
        [EnumMember(Value = "running")]
        Running,

        /// <summary>
        /// Enum Success for "success"
        /// </summary>
        [EnumMember(Value = "success")]
        Success
    }
}
