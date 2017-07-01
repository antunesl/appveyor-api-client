using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class ProjectSecurityDescriptorRoleAce : IEquatable<ProjectSecurityDescriptorRoleAce>//, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsSecurityDescriptorRoleAces" /> class.
        /// </summary>
        /// <param name="RoleId">RoleId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="IsAdmin">IsAdmin.</param>
        /// <param name="AccessRights">AccessRights.</param>
        public ProjectSecurityDescriptorRoleAce(int? RoleId = default(int?), string Name = default(string), bool? IsAdmin = default(bool?), List<ProjectSecurityDescriptorAccessRight> AccessRights = default(List<ProjectSecurityDescriptorAccessRight>))
        {
            this.RoleId = RoleId;
            this.Name = Name;
            this.IsAdmin = IsAdmin;
            this.AccessRights = AccessRights;
        }

        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name = "roleId", EmitDefaultValue = false)]
        public int? RoleId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name = "isAdmin", EmitDefaultValue = false)]
        public bool? IsAdmin { get; set; }
        /// <summary>
        /// Gets or Sets AccessRights
        /// </summary>
        [DataMember(Name = "accessRights", EmitDefaultValue = false)]
        public List<ProjectSecurityDescriptorAccessRight> AccessRights { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsSecurityDescriptorRoleAces {\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  AccessRights: ").Append(AccessRights).Append("\n");
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
            return this.Equals(obj as ProjectSecurityDescriptorRoleAce);
        }

        /// <summary>
        /// Returns true if ProjectsSecurityDescriptorRoleAces instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectsSecurityDescriptorRoleAces to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectSecurityDescriptorRoleAce other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.RoleId == other.RoleId ||
                    this.RoleId != null &&
                    this.RoleId.Equals(other.RoleId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.IsAdmin == other.IsAdmin ||
                    this.IsAdmin != null &&
                    this.IsAdmin.Equals(other.IsAdmin)
                ) &&
                (
                    this.AccessRights == other.AccessRights ||
                    this.AccessRights != null &&
                    this.AccessRights.SequenceEqual(other.AccessRights)
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
                if (this.RoleId != null)
                    hash = hash * 59 + this.RoleId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.IsAdmin != null)
                    hash = hash * 59 + this.IsAdmin.GetHashCode();
                if (this.AccessRights != null)
                    hash = hash * 59 + this.AccessRights.GetHashCode();
                return hash;
            }
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    // RoleId (int?) minimum
        //    if (this.RoleId < (int?)0)
        //    {
        //        yield return new ValidationResult("Invalid value for RoleId, must be a value greater than or equal to 0.", new[] { "RoleId" });
        //    }

        //    yield break;
        //}
    }

}
