using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class ProjectNuGetFeed : IEquatable<ProjectNuGetFeed>//, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsNuGetFeed" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="ProjectId">ProjectId.</param>
        /// <param name="PublishingEnabled">PublishingEnabled.</param>
        public ProjectNuGetFeed(string Id = default(string), string Name = default(string), int? AccountId = default(int?), int? ProjectId = default(int?), bool? PublishingEnabled = default(bool?))
        {
            this.Id = Id;
            this.Name = Name;
            this.AccountId = AccountId;
            this.ProjectId = ProjectId;
            this.PublishingEnabled = PublishingEnabled;
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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public int? AccountId { get; set; }
        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "projectId", EmitDefaultValue = false)]
        public int? ProjectId { get; set; }
        /// <summary>
        /// Gets or Sets PublishingEnabled
        /// </summary>
        [DataMember(Name = "publishingEnabled", EmitDefaultValue = false)]
        public bool? PublishingEnabled { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsNuGetFeed {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  PublishingEnabled: ").Append(PublishingEnabled).Append("\n");
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
            return this.Equals(obj as ProjectNuGetFeed);
        }

        /// <summary>
        /// Returns true if ProjectsNuGetFeed instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectsNuGetFeed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectNuGetFeed other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) &&
                (
                    this.ProjectId == other.ProjectId ||
                    this.ProjectId != null &&
                    this.ProjectId.Equals(other.ProjectId)
                ) &&
                (
                    this.PublishingEnabled == other.PublishingEnabled ||
                    this.PublishingEnabled != null &&
                    this.PublishingEnabled.Equals(other.PublishingEnabled)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.ProjectId != null)
                    hash = hash * 59 + this.ProjectId.GetHashCode();
                if (this.PublishingEnabled != null)
                    hash = hash * 59 + this.PublishingEnabled.GetHashCode();
                return hash;
            }
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    // AccountId (int?) minimum
        //    if (this.AccountId < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for AccountId, must be a value greater than or equal to 0.", new[] { "AccountId" });
        //    }

        //    // ProjectId (int?) minimum
        //    if (this.ProjectId < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for ProjectId, must be a value greater than or equal to 0.", new[] { "ProjectId" });
        //    }

        //    yield break;
        //}
    }
}
