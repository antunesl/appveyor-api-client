using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class Build : IEquatable<Build>//, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
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

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsBuilds" /> class.
        /// </summary>
        /// <param name="Branch">Branch.</param>
        /// <param name="BuildId">BuildId.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Jobs">Always empty in getProjectHistory and startDeployment responses..</param>
        /// <param name="BuildNumber">BuildNumber.</param>
        /// <param name="MessageExtended">MessageExtended.</param>
        /// <param name="IsTag">IsTag.</param>
        /// <param name="CommitId">CommitId.</param>
        /// <param name="AuthorName">AuthorName.</param>
        /// <param name="AuthorUsername">AuthorUsername.</param>
        /// <param name="CommitterName">CommitterName.</param>
        /// <param name="CommitterUsername">CommitterUsername.</param>
        /// <param name="Committed">Committed.</param>
        /// <param name="PullRequestId">PullRequestId.</param>
        /// <param name="PullRequestName">PullRequestName.</param>
        /// <param name="Messages">Messages.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Started">Started.</param>
        /// <param name="Finished">Finished.</param>
        public Build(string Branch = default(string), int? BuildId = default(int?), string Message = default(string), string Version = default(string), List<ProjectJob> Jobs = default(List<ProjectJob>), int? BuildNumber = default(int?), string MessageExtended = default(string), bool? IsTag = default(bool?), string CommitId = default(string), string AuthorName = default(string), string AuthorUsername = default(string), string CommitterName = default(string), string CommitterUsername = default(string), DateTime? Committed = default(DateTime?), int? PullRequestId = default(int?), string PullRequestName = default(string), List<ProjectMessage> Messages = default(List<ProjectMessage>), StatusEnum? Status = default(StatusEnum?), DateTime? Started = default(DateTime?), DateTime? Finished = default(DateTime?))
        {
            this.Branch = Branch;
            this.BuildId = BuildId;
            this.Message = Message;
            this.Version = Version;
            this.Jobs = Jobs;
            this.BuildNumber = BuildNumber;
            this.MessageExtended = MessageExtended;
            this.IsTag = IsTag;
            this.CommitId = CommitId;
            this.AuthorName = AuthorName;
            this.AuthorUsername = AuthorUsername;
            this.CommitterName = CommitterName;
            this.CommitterUsername = CommitterUsername;
            this.Committed = Committed;
            this.PullRequestId = PullRequestId;
            this.PullRequestName = PullRequestName;
            this.Messages = Messages;
            this.Status = Status;
            this.Started = Started;
            this.Finished = Finished;
        }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name = "branch", EmitDefaultValue = false)]
        public string Branch { get; set; }
        /// <summary>
        /// Gets or Sets BuildId
        /// </summary>
        [DataMember(Name = "buildId", EmitDefaultValue = false)]
        public int? BuildId { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string Version { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime? Created { get; private set; }
        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public DateTime? Updated { get; private set; }
        /// <summary>
        /// Always empty in getProjectHistory and startDeployment responses.
        /// </summary>
        /// <value>Always empty in getProjectHistory and startDeployment responses.</value>
        [DataMember(Name = "jobs", EmitDefaultValue = false)]
        public List<ProjectJob> Jobs { get; set; }
        /// <summary>
        /// Gets or Sets BuildNumber
        /// </summary>
        [DataMember(Name = "buildNumber", EmitDefaultValue = false)]
        public int? BuildNumber { get; set; }
        /// <summary>
        /// Gets or Sets MessageExtended
        /// </summary>
        [DataMember(Name = "messageExtended", EmitDefaultValue = false)]
        public string MessageExtended { get; set; }
        /// <summary>
        /// Gets or Sets IsTag
        /// </summary>
        [DataMember(Name = "isTag", EmitDefaultValue = false)]
        public bool? IsTag { get; set; }
        /// <summary>
        /// Gets or Sets CommitId
        /// </summary>
        [DataMember(Name = "commitId", EmitDefaultValue = false)]
        public string CommitId { get; set; }
        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name = "authorName", EmitDefaultValue = false)]
        public string AuthorName { get; set; }
        /// <summary>
        /// Gets or Sets AuthorUsername
        /// </summary>
        [DataMember(Name = "authorUsername", EmitDefaultValue = false)]
        public string AuthorUsername { get; set; }
        /// <summary>
        /// Gets or Sets CommitterName
        /// </summary>
        [DataMember(Name = "committerName", EmitDefaultValue = false)]
        public string CommitterName { get; set; }
        /// <summary>
        /// Gets or Sets CommitterUsername
        /// </summary>
        [DataMember(Name = "committerUsername", EmitDefaultValue = false)]
        public string CommitterUsername { get; set; }
        /// <summary>
        /// Gets or Sets Committed
        /// </summary>
        [DataMember(Name = "committed", EmitDefaultValue = false)]
        public DateTime? Committed { get; set; }
        /// <summary>
        /// Gets or Sets PullRequestId
        /// </summary>
        [DataMember(Name = "pullRequestId", EmitDefaultValue = false)]
        public int? PullRequestId { get; set; }
        /// <summary>
        /// Gets or Sets PullRequestName
        /// </summary>
        [DataMember(Name = "pullRequestName", EmitDefaultValue = false)]
        public string PullRequestName { get; set; }
        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<ProjectMessage> Messages { get; set; }
        /// <summary>
        /// Gets or Sets Started
        /// </summary>
        [DataMember(Name = "started", EmitDefaultValue = false)]
        public DateTime? Started { get; set; }
        /// <summary>
        /// Gets or Sets Finished
        /// </summary>
        [DataMember(Name = "finished", EmitDefaultValue = false)]
        public DateTime? Finished { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsBuilds {\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  BuildId: ").Append(BuildId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
            sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("  MessageExtended: ").Append(MessageExtended).Append("\n");
            sb.Append("  IsTag: ").Append(IsTag).Append("\n");
            sb.Append("  CommitId: ").Append(CommitId).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  AuthorUsername: ").Append(AuthorUsername).Append("\n");
            sb.Append("  CommitterName: ").Append(CommitterName).Append("\n");
            sb.Append("  CommitterUsername: ").Append(CommitterUsername).Append("\n");
            sb.Append("  Committed: ").Append(Committed).Append("\n");
            sb.Append("  PullRequestId: ").Append(PullRequestId).Append("\n");
            sb.Append("  PullRequestName: ").Append(PullRequestName).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Build);
        }

        /// <summary>
        /// Returns true if ProjectsBuilds instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectsBuilds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Build other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Branch == other.Branch ||
                    this.Branch != null &&
                    this.Branch.Equals(other.Branch)
                ) &&
                (
                    this.BuildId == other.BuildId ||
                    this.BuildId != null &&
                    this.BuildId.Equals(other.BuildId)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) &&
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) &&
                (
                    this.Jobs == other.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.SequenceEqual(other.Jobs)
                ) &&
                (
                    this.BuildNumber == other.BuildNumber ||
                    this.BuildNumber != null &&
                    this.BuildNumber.Equals(other.BuildNumber)
                ) &&
                (
                    this.MessageExtended == other.MessageExtended ||
                    this.MessageExtended != null &&
                    this.MessageExtended.Equals(other.MessageExtended)
                ) &&
                (
                    this.IsTag == other.IsTag ||
                    this.IsTag != null &&
                    this.IsTag.Equals(other.IsTag)
                ) &&
                (
                    this.CommitId == other.CommitId ||
                    this.CommitId != null &&
                    this.CommitId.Equals(other.CommitId)
                ) &&
                (
                    this.AuthorName == other.AuthorName ||
                    this.AuthorName != null &&
                    this.AuthorName.Equals(other.AuthorName)
                ) &&
                (
                    this.AuthorUsername == other.AuthorUsername ||
                    this.AuthorUsername != null &&
                    this.AuthorUsername.Equals(other.AuthorUsername)
                ) &&
                (
                    this.CommitterName == other.CommitterName ||
                    this.CommitterName != null &&
                    this.CommitterName.Equals(other.CommitterName)
                ) &&
                (
                    this.CommitterUsername == other.CommitterUsername ||
                    this.CommitterUsername != null &&
                    this.CommitterUsername.Equals(other.CommitterUsername)
                ) &&
                (
                    this.Committed == other.Committed ||
                    this.Committed != null &&
                    this.Committed.Equals(other.Committed)
                ) &&
                (
                    this.PullRequestId == other.PullRequestId ||
                    this.PullRequestId != null &&
                    this.PullRequestId.Equals(other.PullRequestId)
                ) &&
                (
                    this.PullRequestName == other.PullRequestName ||
                    this.PullRequestName != null &&
                    this.PullRequestName.Equals(other.PullRequestName)
                ) &&
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Started == other.Started ||
                    this.Started != null &&
                    this.Started.Equals(other.Started)
                ) &&
                (
                    this.Finished == other.Finished ||
                    this.Finished != null &&
                    this.Finished.Equals(other.Finished)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Branch != null)
                    hash = hash * 59 + this.Branch.GetHashCode();
                if (this.BuildId != null)
                    hash = hash * 59 + this.BuildId.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.Jobs != null)
                    hash = hash * 59 + this.Jobs.GetHashCode();
                if (this.BuildNumber != null)
                    hash = hash * 59 + this.BuildNumber.GetHashCode();
                if (this.MessageExtended != null)
                    hash = hash * 59 + this.MessageExtended.GetHashCode();
                if (this.IsTag != null)
                    hash = hash * 59 + this.IsTag.GetHashCode();
                if (this.CommitId != null)
                    hash = hash * 59 + this.CommitId.GetHashCode();
                if (this.AuthorName != null)
                    hash = hash * 59 + this.AuthorName.GetHashCode();
                if (this.AuthorUsername != null)
                    hash = hash * 59 + this.AuthorUsername.GetHashCode();
                if (this.CommitterName != null)
                    hash = hash * 59 + this.CommitterName.GetHashCode();
                if (this.CommitterUsername != null)
                    hash = hash * 59 + this.CommitterUsername.GetHashCode();
                if (this.Committed != null)
                    hash = hash * 59 + this.Committed.GetHashCode();
                if (this.PullRequestId != null)
                    hash = hash * 59 + this.PullRequestId.GetHashCode();
                if (this.PullRequestName != null)
                    hash = hash * 59 + this.PullRequestName.GetHashCode();
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Started != null)
                    hash = hash * 59 + this.Started.GetHashCode();
                if (this.Finished != null)
                    hash = hash * 59 + this.Finished.GetHashCode();
                return hash;
            }
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    // BuildId (int?) minimum
        //    if (this.BuildId < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for BuildId, must be a value greater than or equal to 0.", new[] { "BuildId" });
        //    }

        //    // BuildNumber (int?) minimum
        //    if (this.BuildNumber < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for BuildNumber, must be a value greater than or equal to 0.", new[] { "BuildNumber" });
        //    }

        //    // PullRequestId (int?) minimum
        //    if (this.PullRequestId < (int?)1)
        //    {
        //        yield return new ValidationResult("Invalid value for PullRequestId, must be a value greater than or equal to 1.", new[] { "PullRequestId" });
        //    }

        //    yield break;
        //}
    }
}
