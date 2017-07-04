using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    public class StartBuildInfo : IEquatable<StartBuildInfo>
    {


        public StartBuildInfo(string AccountName = default(string), string ProjectSlug = default(string), string Branch = default(string), string CommitId = default(string), int? PullRequestId = default(int?), Dictionary<string, string> EnvironmentVariables = default(Dictionary<string, string>))
        {
            // to ensure "AccountName" is required (not null)
            if (AccountName == null)
            {
                throw new ArgumentNullException("AccountName is a required property for Body10 and cannot be null");
            }
            else
            {
                this.AccountName = AccountName;
            }
            // to ensure "ProjectSlug" is required (not null)
            if (ProjectSlug == null)
            {
                throw new ArgumentNullException("ProjectSlug is a required property for Body10 and cannot be null");
            }
            else
            {
                this.ProjectSlug = ProjectSlug;
            }
            this.Branch = Branch;
            this.CommitId = CommitId;
            this.PullRequestId = PullRequestId;
            this.EnvironmentVariables = EnvironmentVariables;
        }


        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name = "accountName", EmitDefaultValue = false)]
        public string AccountName { get; set; }
        /// <summary>
        /// Gets or Sets ProjectSlug
        /// </summary>
        [DataMember(Name = "projectSlug", EmitDefaultValue = false)]
        public string ProjectSlug { get; set; }
        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name = "branch", EmitDefaultValue = false)]
        public string Branch { get; set; }
        /// <summary>
        /// Gets or Sets CommitId
        /// </summary>
        [DataMember(Name = "commitId", EmitDefaultValue = false)]
        public string CommitId { get; set; }
        /// <summary>
        /// Can not be used with &#x60;branch&#x60; or &#x60;commitId&#x60;
        /// </summary>
        /// <value>Can not be used with &#x60;branch&#x60; or &#x60;commitId&#x60;</value>
        [DataMember(Name = "pullRequestId", EmitDefaultValue = false)]
        public int? PullRequestId { get; set; }
        /// <summary>
        /// Gets or Sets EnvironmentVariables
        /// </summary>
        [DataMember(Name = "environmentVariables", EmitDefaultValue = false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body10 {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ProjectSlug: ").Append(ProjectSlug).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CommitId: ").Append(CommitId).Append("\n");
            sb.Append("  PullRequestId: ").Append(PullRequestId).Append("\n");
            sb.Append("  EnvironmentVariables: ").Append(EnvironmentVariables).Append("\n");
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
            return this.Equals(obj as StartBuildInfo);
        }

        /// <summary>
        /// Returns true if Body10 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body10 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartBuildInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) &&
                (
                    this.ProjectSlug == other.ProjectSlug ||
                    this.ProjectSlug != null &&
                    this.ProjectSlug.Equals(other.ProjectSlug)
                ) &&
                (
                    this.Branch == other.Branch ||
                    this.Branch != null &&
                    this.Branch.Equals(other.Branch)
                ) &&
                (
                    this.CommitId == other.CommitId ||
                    this.CommitId != null &&
                    this.CommitId.Equals(other.CommitId)
                ) &&
                (
                    this.PullRequestId == other.PullRequestId ||
                    this.PullRequestId != null &&
                    this.PullRequestId.Equals(other.PullRequestId)
                ) &&
                (
                    this.EnvironmentVariables == other.EnvironmentVariables ||
                    this.EnvironmentVariables != null &&
                    this.EnvironmentVariables.SequenceEqual(other.EnvironmentVariables)
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
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.ProjectSlug != null)
                    hash = hash * 59 + this.ProjectSlug.GetHashCode();
                if (this.Branch != null)
                    hash = hash * 59 + this.Branch.GetHashCode();
                if (this.CommitId != null)
                    hash = hash * 59 + this.CommitId.GetHashCode();
                if (this.PullRequestId != null)
                    hash = hash * 59 + this.PullRequestId.GetHashCode();
                if (this.EnvironmentVariables != null)
                    hash = hash * 59 + this.EnvironmentVariables.GetHashCode();
                return hash;
            }
        }
    }
}
