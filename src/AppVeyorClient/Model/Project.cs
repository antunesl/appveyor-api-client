using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class Project : IEquatable<Project>//, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RepositoryType
        /// </summary>
        [DataMember(Name = "repositoryType", EmitDefaultValue = false)]
        public RepositoryTypeEnum? RepositoryType { get; set; }
        /// <summary>
        /// Gets or Sets RepositoryScm
        /// </summary>
        [DataMember(Name = "repositoryScm", EmitDefaultValue = false)]
        public RepositoryScmEnum? RepositoryScm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        [JsonConstructor]
        protected Project() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="ProjectId">ProjectId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Builds">Only non-empty for response from getProjects..</param>
        /// <param name="RepositoryType">RepositoryType.</param>
        /// <param name="RepositoryScm">RepositoryScm.</param>
        /// <param name="RepositoryName">RepositoryName (required).</param>
        /// <param name="RepositoryBranch">Not present in response from addProject..</param>
        /// <param name="IsPrivate">IsPrivate.</param>
        /// <param name="SkipBranchesWithoutAppveyorYml">SkipBranchesWithoutAppveyorYml.</param>
        /// <param name="EnableSecureVariablesInPullRequests">EnableSecureVariablesInPullRequests.</param>
        /// <param name="EnableSecureVariablesInPullRequestsFromSameRepo">EnableSecureVariablesInPullRequestsFromSameRepo.</param>
        /// <param name="EnableDeploymentInPullRequests">EnableDeploymentInPullRequests.</param>
        /// <param name="RollingBuilds">RollingBuilds.</param>
        /// <param name="RollingBuildsDoNotCancelRunningBuilds">RollingBuildsDoNotCancelRunningBuilds.</param>
        /// <param name="AlwaysBuildClosedPullRequests">AlwaysBuildClosedPullRequests.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="NuGetFeed">NuGetFeed.</param>
        /// <param name="SecurityDescriptor">SecurityDescriptor.</param>
        public Project(int? ProjectId = default(int?), string Name = default(string), List<Build> Builds = default(List<Build>), RepositoryTypeEnum? RepositoryType = default(RepositoryTypeEnum?), RepositoryScmEnum? RepositoryScm = default(RepositoryScmEnum?), string RepositoryName = default(string), string RepositoryBranch = default(string), bool? IsPrivate = default(bool?), bool? SkipBranchesWithoutAppveyorYml = default(bool?), bool? EnableSecureVariablesInPullRequests = default(bool?), bool? EnableSecureVariablesInPullRequestsFromSameRepo = default(bool?), bool? EnableDeploymentInPullRequests = default(bool?), bool? RollingBuilds = default(bool?), bool? RollingBuildsDoNotCancelRunningBuilds = default(bool?), bool? AlwaysBuildClosedPullRequests = default(bool?), string Tags = default(string), ProjectNuGetFeed NuGetFeed = default(ProjectNuGetFeed), ProjectSecurityDescriptor SecurityDescriptor = default(ProjectSecurityDescriptor))
        {
            // to ensure "RepositoryName" is required (not null)
            if (RepositoryName == null)
            {
                throw new ArgumentNullException(nameof(RepositoryName), "RepositoryName is a required property for Project and cannot be null");
            }
            else
            {
                this.RepositoryName = RepositoryName;
            }
            this.ProjectId = ProjectId;
            this.Name = Name;
            this.Builds = Builds;
            this.RepositoryType = RepositoryType;
            this.RepositoryScm = RepositoryScm;
            this.RepositoryBranch = RepositoryBranch;
            this.IsPrivate = IsPrivate;
            this.SkipBranchesWithoutAppveyorYml = SkipBranchesWithoutAppveyorYml;
            this.EnableSecureVariablesInPullRequests = EnableSecureVariablesInPullRequests;
            this.EnableSecureVariablesInPullRequestsFromSameRepo = EnableSecureVariablesInPullRequestsFromSameRepo;
            this.EnableDeploymentInPullRequests = EnableDeploymentInPullRequests;
            this.RollingBuilds = RollingBuilds;
            this.RollingBuildsDoNotCancelRunningBuilds = RollingBuildsDoNotCancelRunningBuilds;
            this.AlwaysBuildClosedPullRequests = AlwaysBuildClosedPullRequests;
            this.Tags = Tags;
            this.NuGetFeed = NuGetFeed;
            this.SecurityDescriptor = SecurityDescriptor;
        }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "projectId", EmitDefaultValue = false)]
        public int? ProjectId { get; set; }
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name = "accountName", EmitDefaultValue = false)]
        public string AccountName { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; private set; }
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
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public int? AccountId { get; private set; }
        /// <summary>
        /// Only non-empty for response from getProjects.
        /// </summary>
        /// <value>Only non-empty for response from getProjects.</value>
        [DataMember(Name = "builds", EmitDefaultValue = false)]
        public List<Build> Builds { get; set; }
        /// <summary>
        /// Gets or Sets RepositoryName
        /// </summary>
        [DataMember(Name = "repositoryName", EmitDefaultValue = false)]
        public string RepositoryName { get; set; }
        /// <summary>
        /// Not present in response from addProject.
        /// </summary>
        /// <value>Not present in response from addProject.</value>
        [DataMember(Name = "repositoryBranch", EmitDefaultValue = false)]
        public string RepositoryBranch { get; set; }
        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [DataMember(Name = "isPrivate", EmitDefaultValue = false)]
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// Gets or Sets SkipBranchesWithoutAppveyorYml
        /// </summary>
        [DataMember(Name = "skipBranchesWithoutAppveyorYml", EmitDefaultValue = false)]
        public bool? SkipBranchesWithoutAppveyorYml { get; set; }
        /// <summary>
        /// Gets or Sets EnableSecureVariablesInPullRequests
        /// </summary>
        [DataMember(Name = "enableSecureVariablesInPullRequests", EmitDefaultValue = false)]
        public bool? EnableSecureVariablesInPullRequests { get; set; }
        /// <summary>
        /// Gets or Sets EnableSecureVariablesInPullRequestsFromSameRepo
        /// </summary>
        [DataMember(Name = "enableSecureVariablesInPullRequestsFromSameRepo", EmitDefaultValue = false)]
        public bool? EnableSecureVariablesInPullRequestsFromSameRepo { get; set; }
        /// <summary>
        /// Gets or Sets EnableDeploymentInPullRequests
        /// </summary>
        [DataMember(Name = "enableDeploymentInPullRequests", EmitDefaultValue = false)]
        public bool? EnableDeploymentInPullRequests { get; set; }
        /// <summary>
        /// Gets or Sets RollingBuilds
        /// </summary>
        [DataMember(Name = "rollingBuilds", EmitDefaultValue = false)]
        public bool? RollingBuilds { get; set; }
        /// <summary>
        /// Gets or Sets RollingBuildsDoNotCancelRunningBuilds
        /// </summary>
        [DataMember(Name = "rollingBuildsDoNotCancelRunningBuilds", EmitDefaultValue = false)]
        public bool? RollingBuildsDoNotCancelRunningBuilds { get; set; }
        /// <summary>
        /// Gets or Sets AlwaysBuildClosedPullRequests
        /// </summary>
        [DataMember(Name = "alwaysBuildClosedPullRequests", EmitDefaultValue = false)]
        public bool? AlwaysBuildClosedPullRequests { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public string Tags { get; set; }
        /// <summary>
        /// Gets or Sets NuGetFeed
        /// </summary>
        [DataMember(Name = "nuGetFeed", EmitDefaultValue = false)]
        public ProjectNuGetFeed NuGetFeed { get; set; }
        /// <summary>
        /// Gets or Sets SecurityDescriptor
        /// </summary>
        [DataMember(Name = "securityDescriptor", EmitDefaultValue = false)]
        public ProjectSecurityDescriptor SecurityDescriptor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Project {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Builds: ").Append(Builds).Append("\n");
            sb.Append("  RepositoryType: ").Append(RepositoryType).Append("\n");
            sb.Append("  RepositoryScm: ").Append(RepositoryScm).Append("\n");
            sb.Append("  RepositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  RepositoryBranch: ").Append(RepositoryBranch).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  SkipBranchesWithoutAppveyorYml: ").Append(SkipBranchesWithoutAppveyorYml).Append("\n");
            sb.Append("  EnableSecureVariablesInPullRequests: ").Append(EnableSecureVariablesInPullRequests).Append("\n");
            sb.Append("  EnableSecureVariablesInPullRequestsFromSameRepo: ").Append(EnableSecureVariablesInPullRequestsFromSameRepo).Append("\n");
            sb.Append("  EnableDeploymentInPullRequests: ").Append(EnableDeploymentInPullRequests).Append("\n");
            sb.Append("  RollingBuilds: ").Append(RollingBuilds).Append("\n");
            sb.Append("  RollingBuildsDoNotCancelRunningBuilds: ").Append(RollingBuildsDoNotCancelRunningBuilds).Append("\n");
            sb.Append("  AlwaysBuildClosedPullRequests: ").Append(AlwaysBuildClosedPullRequests).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  NuGetFeed: ").Append(NuGetFeed).Append("\n");
            sb.Append("  SecurityDescriptor: ").Append(SecurityDescriptor).Append("\n");
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
            return this.Equals(obj as Project);
        }

        /// <summary>
        /// Returns true if Project instances are equal
        /// </summary>
        /// <param name="other">Instance of Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Project other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.ProjectId == other.ProjectId ||
                    this.ProjectId != null &&
                    this.ProjectId.Equals(other.ProjectId)
                ) &&
                (
                    this.AccountName == other.AccountName ||
                    this.AccountName != null &&
                    this.AccountName.Equals(other.AccountName)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Slug == other.Slug ||
                    this.Slug != null &&
                    this.Slug.Equals(other.Slug)
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
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) &&
                (
                    this.Builds == other.Builds ||
                    this.Builds != null &&
                    this.Builds.SequenceEqual(other.Builds)
                ) &&
                (
                    this.RepositoryType == other.RepositoryType ||
                    this.RepositoryType != null &&
                    this.RepositoryType.Equals(other.RepositoryType)
                ) &&
                (
                    this.RepositoryScm == other.RepositoryScm ||
                    this.RepositoryScm != null &&
                    this.RepositoryScm.Equals(other.RepositoryScm)
                ) &&
                (
                    this.RepositoryName == other.RepositoryName ||
                    this.RepositoryName != null &&
                    this.RepositoryName.Equals(other.RepositoryName)
                ) &&
                (
                    this.RepositoryBranch == other.RepositoryBranch ||
                    this.RepositoryBranch != null &&
                    this.RepositoryBranch.Equals(other.RepositoryBranch)
                ) &&
                (
                    this.IsPrivate == other.IsPrivate ||
                    this.IsPrivate != null &&
                    this.IsPrivate.Equals(other.IsPrivate)
                ) &&
                (
                    this.SkipBranchesWithoutAppveyorYml == other.SkipBranchesWithoutAppveyorYml ||
                    this.SkipBranchesWithoutAppveyorYml != null &&
                    this.SkipBranchesWithoutAppveyorYml.Equals(other.SkipBranchesWithoutAppveyorYml)
                ) &&
                (
                    this.EnableSecureVariablesInPullRequests == other.EnableSecureVariablesInPullRequests ||
                    this.EnableSecureVariablesInPullRequests != null &&
                    this.EnableSecureVariablesInPullRequests.Equals(other.EnableSecureVariablesInPullRequests)
                ) &&
                (
                    this.EnableSecureVariablesInPullRequestsFromSameRepo == other.EnableSecureVariablesInPullRequestsFromSameRepo ||
                    this.EnableSecureVariablesInPullRequestsFromSameRepo != null &&
                    this.EnableSecureVariablesInPullRequestsFromSameRepo.Equals(other.EnableSecureVariablesInPullRequestsFromSameRepo)
                ) &&
                (
                    this.EnableDeploymentInPullRequests == other.EnableDeploymentInPullRequests ||
                    this.EnableDeploymentInPullRequests != null &&
                    this.EnableDeploymentInPullRequests.Equals(other.EnableDeploymentInPullRequests)
                ) &&
                (
                    this.RollingBuilds == other.RollingBuilds ||
                    this.RollingBuilds != null &&
                    this.RollingBuilds.Equals(other.RollingBuilds)
                ) &&
                (
                    this.RollingBuildsDoNotCancelRunningBuilds == other.RollingBuildsDoNotCancelRunningBuilds ||
                    this.RollingBuildsDoNotCancelRunningBuilds != null &&
                    this.RollingBuildsDoNotCancelRunningBuilds.Equals(other.RollingBuildsDoNotCancelRunningBuilds)
                ) &&
                (
                    this.AlwaysBuildClosedPullRequests == other.AlwaysBuildClosedPullRequests ||
                    this.AlwaysBuildClosedPullRequests != null &&
                    this.AlwaysBuildClosedPullRequests.Equals(other.AlwaysBuildClosedPullRequests)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) &&
                (
                    this.NuGetFeed == other.NuGetFeed ||
                    this.NuGetFeed != null &&
                    this.NuGetFeed.Equals(other.NuGetFeed)
                ) &&
                (
                    this.SecurityDescriptor == other.SecurityDescriptor ||
                    this.SecurityDescriptor != null &&
                    this.SecurityDescriptor.Equals(other.SecurityDescriptor)
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
                if (this.ProjectId != null)
                    hash = hash * 59 + this.ProjectId.GetHashCode();
                if (this.AccountName != null)
                    hash = hash * 59 + this.AccountName.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Slug != null)
                    hash = hash * 59 + this.Slug.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.Builds != null)
                    hash = hash * 59 + this.Builds.GetHashCode();
                if (this.RepositoryType != null)
                    hash = hash * 59 + this.RepositoryType.GetHashCode();
                if (this.RepositoryScm != null)
                    hash = hash * 59 + this.RepositoryScm.GetHashCode();
                if (this.RepositoryName != null)
                    hash = hash * 59 + this.RepositoryName.GetHashCode();
                if (this.RepositoryBranch != null)
                    hash = hash * 59 + this.RepositoryBranch.GetHashCode();
                if (this.IsPrivate != null)
                    hash = hash * 59 + this.IsPrivate.GetHashCode();
                if (this.SkipBranchesWithoutAppveyorYml != null)
                    hash = hash * 59 + this.SkipBranchesWithoutAppveyorYml.GetHashCode();
                if (this.EnableSecureVariablesInPullRequests != null)
                    hash = hash * 59 + this.EnableSecureVariablesInPullRequests.GetHashCode();
                if (this.EnableSecureVariablesInPullRequestsFromSameRepo != null)
                    hash = hash * 59 + this.EnableSecureVariablesInPullRequestsFromSameRepo.GetHashCode();
                if (this.EnableDeploymentInPullRequests != null)
                    hash = hash * 59 + this.EnableDeploymentInPullRequests.GetHashCode();
                if (this.RollingBuilds != null)
                    hash = hash * 59 + this.RollingBuilds.GetHashCode();
                if (this.RollingBuildsDoNotCancelRunningBuilds != null)
                    hash = hash * 59 + this.RollingBuildsDoNotCancelRunningBuilds.GetHashCode();
                if (this.AlwaysBuildClosedPullRequests != null)
                    hash = hash * 59 + this.AlwaysBuildClosedPullRequests.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.NuGetFeed != null)
                    hash = hash * 59 + this.NuGetFeed.GetHashCode();
                if (this.SecurityDescriptor != null)
                    hash = hash * 59 + this.SecurityDescriptor.GetHashCode();
                return hash;
            }
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    // ProjectId (int?) minimum
        //    if (this.ProjectId < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for ProjectId, must be a value greater than or equal to 0.", new[] { "ProjectId" });
        //    }

        //    // AccountId (int?) minimum
        //    if (this.AccountId < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for AccountId, must be a value greater than or equal to 0.", new[] { "AccountId" });
        //    }

        //    yield break;
        //}
    }

}
