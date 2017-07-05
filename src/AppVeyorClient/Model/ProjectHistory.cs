using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    public class ProjectHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectHistory" /> class.
        /// </summary>
        /// <param name="Project">Project.</param>
        /// <param name="Builds">Builds.</param>
        public ProjectHistory(Project Project = default(Project), List<Build> Builds = default(List<Build>))
        {
            this.Project = Project;
            this.Builds = Builds;
        }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        public Project Project { get; set; }
        /// <summary>
        /// Gets or Sets Builds
        /// </summary>
        [DataMember(Name = "builds", EmitDefaultValue = false)]
        public List<Build> Builds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProjectHistoryResponse {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Builds: ").Append(Builds).Append("\n");
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
            return this.Equals(obj as ProjectHistory);
        }

        /// <summary>
        /// Returns true if InlineResponse2005 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2005 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectHistory other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Project == other.Project ||
                    this.Project != null &&
                    this.Project.Equals(other.Project)
                ) &&
                (
                    this.Builds == other.Builds ||
                    this.Builds != null &&
                    this.Builds.SequenceEqual(other.Builds)
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
                if (this.Project != null)
                    hash = hash * 59 + this.Project.GetHashCode();
                if (this.Builds != null)
                    hash = hash * 59 + this.Builds.GetHashCode();
                return hash;
            }
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    yield break;
        //}
    }
}
