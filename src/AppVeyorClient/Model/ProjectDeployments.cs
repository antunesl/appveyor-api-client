﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    public class ProjectDeployments
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2006" /> class.
        /// </summary>
        /// <param name="Project">Project.</param>
        /// <param name="Deployments">Deployments.</param>
        public ProjectDeployments(Project Project = default(Project), List<Deployment> Deployments = default(List<Deployment>))
        {
            this.Project = Project;
            this.Deployments = Deployments;
        }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        public Project Project { get; set; }
        /// <summary>
        /// Gets or Sets Deployments
        /// </summary>
        [DataMember(Name = "deployments", EmitDefaultValue = false)]
        public List<Deployment> Deployments { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2006 {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Deployments: ").Append(Deployments).Append("\n");
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
            return this.Equals(obj as ProjectDeployments);
        }

        /// <summary>
        /// Returns true if InlineResponse2006 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2006 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectDeployments other)
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
                    this.Deployments == other.Deployments ||
                    this.Deployments != null &&
                    this.Deployments.SequenceEqual(other.Deployments)
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
                if (this.Deployments != null)
                    hash = hash * 59 + this.Deployments.GetHashCode();
                return hash;
            }
        }
    }
}
