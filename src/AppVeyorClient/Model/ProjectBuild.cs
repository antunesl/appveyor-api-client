using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class ProjectBuild : IEquatable<ProjectBuild>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectBuild" /> class.
        /// </summary>
        /// <param name="Project">Project.</param>
        /// <param name="Build">Build.</param>
        public ProjectBuild(Project Project = default(Project), Build Build = default(Build))
        {
            this.Project = Project;
            this.Build = Build;
        }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        public Project Project { get; set; }
        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name = "build", EmitDefaultValue = false)]
        public Build Build { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2004 {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
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
            return this.Equals(obj as ProjectBuild);
        }

        /// <summary>
        /// Returns true if InlineResponse2004 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2004 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectBuild other)
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
                    this.Build == other.Build ||
                    this.Build != null &&
                    this.Build.Equals(other.Build)
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
                if (this.Build != null)
                    hash = hash * 59 + this.Build.GetHashCode();
                return hash;
            }
        }


    }
}
