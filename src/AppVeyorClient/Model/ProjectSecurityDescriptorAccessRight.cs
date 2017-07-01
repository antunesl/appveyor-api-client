using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class ProjectSecurityDescriptorAccessRight : IEquatable<ProjectSecurityDescriptorAccessRight>//, IValidatableObject
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
        /// Initializes a new instance of the <see cref="ProjectsSecurityDescriptorAccessRights" /> class.
        /// </summary>
        [JsonConstructor]
        protected ProjectSecurityDescriptorAccessRight() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsSecurityDescriptorAccessRights" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Allowed">Allowed.</param>
        public ProjectSecurityDescriptorAccessRight(NameEnum? Name = default(NameEnum?), bool? Allowed = default(bool?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new ArgumentNullException(nameof(Name), "Name is a required property for ProjectsSecurityDescriptorAccessRights and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Allowed = Allowed;
        }

        /// <summary>
        /// Gets or Sets Allowed
        /// </summary>
        [DataMember(Name = "allowed", EmitDefaultValue = false)]
        public bool? Allowed { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsSecurityDescriptorAccessRights {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
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
            return this.Equals(obj as ProjectSecurityDescriptorAccessRight);
        }

        /// <summary>
        /// Returns true if ProjectsSecurityDescriptorAccessRights instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectsSecurityDescriptorAccessRights to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectSecurityDescriptorAccessRight other)
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
                    this.Allowed == other.Allowed ||
                    this.Allowed != null &&
                    this.Allowed.Equals(other.Allowed)
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
                if (this.Allowed != null)
                    hash = hash * 59 + this.Allowed.GetHashCode();
                return hash;
            }
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    yield break;
        //}
    }

}
