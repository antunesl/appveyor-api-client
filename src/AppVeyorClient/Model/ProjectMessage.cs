using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class ProjectMessage : IEquatable<ProjectMessage>//, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {

            /// <summary>
            /// Enum Information for "information"
            /// </summary>
            [EnumMember(Value = "information")]
            Information,

            /// <summary>
            /// Enum Warning for "warning"
            /// </summary>
            [EnumMember(Value = "warning")]
            Warning
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsMessages" /> class.
        /// </summary>
        /// <param name="Category">Category.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Created">Created.</param>
        public ProjectMessage(CategoryEnum? Category = default(CategoryEnum?), string Message = default(string), DateTime? Created = default(DateTime?))
        {
            this.Category = Category;
            this.Message = Message;
            this.Created = Created;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsMessages {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
            return this.Equals(obj as ProjectMessage);
        }

        /// <summary>
        /// Returns true if ProjectsMessages instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectsMessages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                return hash;
            }
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    yield break;
        //}
    }

}
