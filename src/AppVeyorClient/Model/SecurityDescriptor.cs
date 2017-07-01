using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class SecurityDescriptor : IEquatable<SecurityDescriptor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityDescriptor" /> class.
        /// </summary>
        /// <param name="AccessRightDefinitions">AccessRightDefinitions.</param>
        /// <param name="RoleAces">RoleAces.</param>
        public SecurityDescriptor(List<ProjectSecurityDescriptorAccessRightDefinition> AccessRightDefinitions = default(List<ProjectSecurityDescriptorAccessRightDefinition>), List<ProjectSecurityDescriptorRoleAce> RoleAces = default(List<ProjectSecurityDescriptorRoleAce>))
        {
            this.AccessRightDefinitions = AccessRightDefinitions;
            this.RoleAces = RoleAces;
        }

        /// <summary>
        /// Gets or Sets AccessRightDefinitions
        /// </summary>
        [DataMember(Name = "accessRightDefinitions", EmitDefaultValue = false)]
        public List<ProjectSecurityDescriptorAccessRightDefinition> AccessRightDefinitions { get; set; }
        /// <summary>
        /// Gets or Sets RoleAces
        /// </summary>
        [DataMember(Name = "roleAces", EmitDefaultValue = false)]
        public List<ProjectSecurityDescriptorRoleAce> RoleAces { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsSecurityDescriptor {\n");
            sb.Append("  AccessRightDefinitions: ").Append(AccessRightDefinitions).Append("\n");
            sb.Append("  RoleAces: ").Append(RoleAces).Append("\n");
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
            return this.Equals(obj as SecurityDescriptor);
        }

        /// <summary>
        /// Returns true if ProjectsSecurityDescriptor instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectsSecurityDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityDescriptor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.AccessRightDefinitions == other.AccessRightDefinitions ||
                    this.AccessRightDefinitions != null &&
                    this.AccessRightDefinitions.SequenceEqual(other.AccessRightDefinitions)
                ) &&
                (
                    this.RoleAces == other.RoleAces ||
                    this.RoleAces != null &&
                    this.RoleAces.SequenceEqual(other.RoleAces)
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
                if (this.AccessRightDefinitions != null)
                    hash = hash * 59 + this.AccessRightDefinitions.GetHashCode();
                if (this.RoleAces != null)
                    hash = hash * 59 + this.RoleAces.GetHashCode();
                return hash;
            }
        }

    }
}
