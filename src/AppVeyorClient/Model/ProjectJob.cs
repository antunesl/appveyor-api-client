using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class ProjectJob : IEquatable<ProjectJob>//, IValidatableObject
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
        /// Gets or Sets OsType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OsTypeEnum
        {

            /// <summary>
            /// Enum Ubuntu for "Ubuntu"
            /// </summary>
            [EnumMember(Value = "Ubuntu")]
            Ubuntu,

            /// <summary>
            /// Enum Windows for "Windows"
            /// </summary>
            [EnumMember(Value = "Windows")]
            Windows
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets OsType
        /// </summary>
        [DataMember(Name = "osType", EmitDefaultValue = false)]
        public OsTypeEnum? OsType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsJobs" /> class.
        /// </summary>
        /// <param name="JobId">JobId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Started">Started.</param>
        /// <param name="Finished">Finished.</param>
        /// <param name="OsType">OsType.</param>
        /// <param name="AllowFailure">AllowFailure.</param>
        /// <param name="MessagesCount">MessagesCount.</param>
        /// <param name="CompilationMessagesCount">CompilationMessagesCount.</param>
        /// <param name="CompilationErrorsCount">CompilationErrorsCount.</param>
        /// <param name="CompilationWarningsCount">CompilationWarningsCount.</param>
        /// <param name="TestsCount">TestsCount.</param>
        /// <param name="PassedTestsCount">PassedTestsCount.</param>
        /// <param name="FailedTestsCount">FailedTestsCount.</param>
        /// <param name="ArtifactsCount">ArtifactsCount.</param>
        public ProjectJob(string JobId = default(string), string Name = default(string), StatusEnum? Status = default(StatusEnum?), DateTime? Started = default(DateTime?), DateTime? Finished = default(DateTime?), OsTypeEnum? OsType = default(OsTypeEnum?), bool? AllowFailure = default(bool?), int? MessagesCount = default(int?), int? CompilationMessagesCount = default(int?), int? CompilationErrorsCount = default(int?), int? CompilationWarningsCount = default(int?), int? TestsCount = default(int?), int? PassedTestsCount = default(int?), int? FailedTestsCount = default(int?), int? ArtifactsCount = default(int?))
        {
            this.JobId = JobId;
            this.Name = Name;
            this.Status = Status;
            this.Started = Started;
            this.Finished = Finished;
            this.OsType = OsType;
            this.AllowFailure = AllowFailure;
            this.MessagesCount = MessagesCount;
            this.CompilationMessagesCount = CompilationMessagesCount;
            this.CompilationErrorsCount = CompilationErrorsCount;
            this.CompilationWarningsCount = CompilationWarningsCount;
            this.TestsCount = TestsCount;
            this.PassedTestsCount = PassedTestsCount;
            this.FailedTestsCount = FailedTestsCount;
            this.ArtifactsCount = ArtifactsCount;
        }

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
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        public string JobId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
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
        /// Gets or Sets AllowFailure
        /// </summary>
        [DataMember(Name = "allowFailure", EmitDefaultValue = false)]
        public bool? AllowFailure { get; set; }
        /// <summary>
        /// Gets or Sets MessagesCount
        /// </summary>
        [DataMember(Name = "messagesCount", EmitDefaultValue = false)]
        public int? MessagesCount { get; set; }
        /// <summary>
        /// Gets or Sets CompilationMessagesCount
        /// </summary>
        [DataMember(Name = "compilationMessagesCount", EmitDefaultValue = false)]
        public int? CompilationMessagesCount { get; set; }
        /// <summary>
        /// Gets or Sets CompilationErrorsCount
        /// </summary>
        [DataMember(Name = "compilationErrorsCount", EmitDefaultValue = false)]
        public int? CompilationErrorsCount { get; set; }
        /// <summary>
        /// Gets or Sets CompilationWarningsCount
        /// </summary>
        [DataMember(Name = "compilationWarningsCount", EmitDefaultValue = false)]
        public int? CompilationWarningsCount { get; set; }
        /// <summary>
        /// Gets or Sets TestsCount
        /// </summary>
        [DataMember(Name = "testsCount", EmitDefaultValue = false)]
        public int? TestsCount { get; set; }
        /// <summary>
        /// Gets or Sets PassedTestsCount
        /// </summary>
        [DataMember(Name = "passedTestsCount", EmitDefaultValue = false)]
        public int? PassedTestsCount { get; set; }
        /// <summary>
        /// Gets or Sets FailedTestsCount
        /// </summary>
        [DataMember(Name = "failedTestsCount", EmitDefaultValue = false)]
        public int? FailedTestsCount { get; set; }
        /// <summary>
        /// Gets or Sets ArtifactsCount
        /// </summary>
        [DataMember(Name = "artifactsCount", EmitDefaultValue = false)]
        public int? ArtifactsCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsJobs {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  OsType: ").Append(OsType).Append("\n");
            sb.Append("  AllowFailure: ").Append(AllowFailure).Append("\n");
            sb.Append("  MessagesCount: ").Append(MessagesCount).Append("\n");
            sb.Append("  CompilationMessagesCount: ").Append(CompilationMessagesCount).Append("\n");
            sb.Append("  CompilationErrorsCount: ").Append(CompilationErrorsCount).Append("\n");
            sb.Append("  CompilationWarningsCount: ").Append(CompilationWarningsCount).Append("\n");
            sb.Append("  TestsCount: ").Append(TestsCount).Append("\n");
            sb.Append("  PassedTestsCount: ").Append(PassedTestsCount).Append("\n");
            sb.Append("  FailedTestsCount: ").Append(FailedTestsCount).Append("\n");
            sb.Append("  ArtifactsCount: ").Append(ArtifactsCount).Append("\n");
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
            return this.Equals(obj as ProjectJob);
        }

        /// <summary>
        /// Returns true if ProjectsJobs instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectsJobs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectJob other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
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
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                ) &&
                (
                    this.OsType == other.OsType ||
                    this.OsType != null &&
                    this.OsType.Equals(other.OsType)
                ) &&
                (
                    this.AllowFailure == other.AllowFailure ||
                    this.AllowFailure != null &&
                    this.AllowFailure.Equals(other.AllowFailure)
                ) &&
                (
                    this.MessagesCount == other.MessagesCount ||
                    this.MessagesCount != null &&
                    this.MessagesCount.Equals(other.MessagesCount)
                ) &&
                (
                    this.CompilationMessagesCount == other.CompilationMessagesCount ||
                    this.CompilationMessagesCount != null &&
                    this.CompilationMessagesCount.Equals(other.CompilationMessagesCount)
                ) &&
                (
                    this.CompilationErrorsCount == other.CompilationErrorsCount ||
                    this.CompilationErrorsCount != null &&
                    this.CompilationErrorsCount.Equals(other.CompilationErrorsCount)
                ) &&
                (
                    this.CompilationWarningsCount == other.CompilationWarningsCount ||
                    this.CompilationWarningsCount != null &&
                    this.CompilationWarningsCount.Equals(other.CompilationWarningsCount)
                ) &&
                (
                    this.TestsCount == other.TestsCount ||
                    this.TestsCount != null &&
                    this.TestsCount.Equals(other.TestsCount)
                ) &&
                (
                    this.PassedTestsCount == other.PassedTestsCount ||
                    this.PassedTestsCount != null &&
                    this.PassedTestsCount.Equals(other.PassedTestsCount)
                ) &&
                (
                    this.FailedTestsCount == other.FailedTestsCount ||
                    this.FailedTestsCount != null &&
                    this.FailedTestsCount.Equals(other.FailedTestsCount)
                ) &&
                (
                    this.ArtifactsCount == other.ArtifactsCount ||
                    this.ArtifactsCount != null &&
                    this.ArtifactsCount.Equals(other.ArtifactsCount)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Started != null)
                    hash = hash * 59 + this.Started.GetHashCode();
                if (this.Finished != null)
                    hash = hash * 59 + this.Finished.GetHashCode();
                if (this.OsType != null)
                    hash = hash * 59 + this.OsType.GetHashCode();
                if (this.AllowFailure != null)
                    hash = hash * 59 + this.AllowFailure.GetHashCode();
                if (this.MessagesCount != null)
                    hash = hash * 59 + this.MessagesCount.GetHashCode();
                if (this.CompilationMessagesCount != null)
                    hash = hash * 59 + this.CompilationMessagesCount.GetHashCode();
                if (this.CompilationErrorsCount != null)
                    hash = hash * 59 + this.CompilationErrorsCount.GetHashCode();
                if (this.CompilationWarningsCount != null)
                    hash = hash * 59 + this.CompilationWarningsCount.GetHashCode();
                if (this.TestsCount != null)
                    hash = hash * 59 + this.TestsCount.GetHashCode();
                if (this.PassedTestsCount != null)
                    hash = hash * 59 + this.PassedTestsCount.GetHashCode();
                if (this.FailedTestsCount != null)
                    hash = hash * 59 + this.FailedTestsCount.GetHashCode();
                if (this.ArtifactsCount != null)
                    hash = hash * 59 + this.ArtifactsCount.GetHashCode();
                return hash;
            }
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    // MessagesCount (int?) minimum
        //    if (this.MessagesCount < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for MessagesCount, must be a value greater than or equal to 0.", new[] { "MessagesCount" });
        //    }

        //    // CompilationMessagesCount (int?) minimum
        //    if (this.CompilationMessagesCount < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for CompilationMessagesCount, must be a value greater than or equal to 0.", new[] { "CompilationMessagesCount" });
        //    }

        //    // CompilationErrorsCount (int?) minimum
        //    if (this.CompilationErrorsCount < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for CompilationErrorsCount, must be a value greater than or equal to 0.", new[] { "CompilationErrorsCount" });
        //    }

        //    // CompilationWarningsCount (int?) minimum
        //    if (this.CompilationWarningsCount < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for CompilationWarningsCount, must be a value greater than or equal to 0.", new[] { "CompilationWarningsCount" });
        //    }

        //    // TestsCount (int?) minimum
        //    if (this.TestsCount < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for TestsCount, must be a value greater than or equal to 0.", new[] { "TestsCount" });
        //    }

        //    // PassedTestsCount (int?) minimum
        //    if (this.PassedTestsCount < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for PassedTestsCount, must be a value greater than or equal to 0.", new[] { "PassedTestsCount" });
        //    }

        //    // FailedTestsCount (int?) minimum
        //    if (this.FailedTestsCount < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for FailedTestsCount, must be a value greater than or equal to 0.", new[] { "FailedTestsCount" });
        //    }

        //    // ArtifactsCount (int?) minimum
        //    if (this.ArtifactsCount < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for ArtifactsCount, must be a value greater than or equal to 0.", new[] { "ArtifactsCount" });
        //    }

        //    yield break;
        //}
    }
}
