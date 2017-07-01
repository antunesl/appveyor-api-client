using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class ProjectSecurityDescriptorAccessRightDefinition : IEquatable<ProjectSecurityDescriptorAccessRightDefinition> //, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {

            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete,

            /// <summary>
            /// Enum Deploy for "Deploy"
            /// </summary>
            [EnumMember(Value = "Deploy")]
            Deploy,

            /// <summary>
            /// Enum RunBuild for "RunBuild"
            /// </summary>
            [EnumMember(Value = "RunBuild")]
            RunBuild,

            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,

            /// <summary>
            /// Enum View for "View"
            /// </summary>
            [EnumMember(Value = "View")]
            View
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsSecurityDescriptorAccessRightDefinitions" /> class.
        /// </summary>
        [JsonConstructor]
        protected ProjectSecurityDescriptorAccessRightDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsSecurityDescriptorAccessRightDefinitions" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Description">Description.</param>
        public ProjectSecurityDescriptorAccessRightDefinition(NameEnum? Name = default(NameEnum?), string Description = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new ArgumentNullException(nameof(Name), "Name is a required property for ProjectsSecurityDescriptorAccessRightDefinitions and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Description = Description;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsSecurityDescriptorAccessRightDefinitions {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as ProjectSecurityDescriptorAccessRightDefinition);
        }

        /// <summary>
        /// Returns true if ProjectsSecurityDescriptorAccessRightDefinitions instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectsSecurityDescriptorAccessRightDefinitions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectSecurityDescriptorAccessRightDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    yield break;
        //}
    }

}