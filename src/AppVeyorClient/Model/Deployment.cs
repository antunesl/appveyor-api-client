using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class Deployment : IEquatable<Deployment>
    {


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DeploymentStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment" /> class.
        /// </summary>
        /// <param name="DeploymentId">DeploymentId.</param>
        /// <param name="Build">Build.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Started">Started.</param>
        /// <param name="Finished">Finished.</param>
        /// <param name="Environment">Environment.</param>
        /// <param name="Jobs">Jobs.</param>
        public Deployment(int? DeploymentId = default(int?), Build Build = default(Build), DeploymentStatus? Status = default(DeploymentStatus?), DateTime? Started = default(DateTime?), DateTime? Finished = default(DateTime?), Environment Environment = default(Environment), List<Job> Jobs = default(List<Job>))
        {
            this.DeploymentId = DeploymentId;
            this.Build = Build;
            this.Status = Status;
            this.Started = Started;
            this.Finished = Finished;
            this.Environment = Environment;
            this.Jobs = Jobs;
        }

        /// <summary>
        /// Gets or Sets DeploymentId
        /// </summary>
        [DataMember(Name = "deploymentId", EmitDefaultValue = false)]
        public int? DeploymentId { get; set; }
        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name = "build", EmitDefaultValue = false)]
        public Build Build { get; set; }
        /// <summary>
        /// Gets or Sets Started
        /// </summary>
        [DataMember(Name = "started", EmitDefaultValue = false)]
        public DateTime? Started { get; set; }
        /// <summary>
        /// Gets or Sets Finished
        /// </summary>
        [DataMember(Name = "finished", EmitDefaultValue = false)]
        public DateTime? Finished { get; set; }
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
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public Environment Environment { get; set; }
        /// <summary>
        /// Gets or Sets Jobs
        /// </summary>
        [DataMember(Name = "jobs", EmitDefaultValue = false)]
        public List<Job> Jobs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Deployment {\n");
            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Started: ").Append(Started).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Jobs: ").Append(Jobs).Append("\n");
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
            return this.Equals(obj as Deployment);
        }

        /// <summary>
        /// Returns true if Deployment instances are equal
        /// </summary>
        /// <param name="other">Instance of Deployment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Deployment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.DeploymentId == other.DeploymentId ||
                    this.DeploymentId != null &&
                    this.DeploymentId.Equals(other.DeploymentId)
                ) &&
                (
                    this.Build == other.Build ||
                    this.Build != null &&
                    this.Build.Equals(other.Build)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Started == other.Started ||
                    this.Started != null &&
                    this.Started.Equals(other.Started)
                ) &&
                (
                    this.Finished == other.Finished ||
                    this.Finished != null &&
                    this.Finished.Equals(other.Finished)
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
                    this.Environment == other.Environment ||
                    this.Environment != null &&
                    this.Environment.Equals(other.Environment)
                ) &&
                (
                    this.Jobs == other.Jobs ||
                    this.Jobs != null &&
                    this.Jobs.SequenceEqual(other.Jobs)
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
                if (this.DeploymentId != null)
                    hash = hash * 59 + this.DeploymentId.GetHashCode();
                if (this.Build != null)
                    hash = hash * 59 + this.Build.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Started != null)
                    hash = hash * 59 + this.Started.GetHashCode();
                if (this.Finished != null)
                    hash = hash * 59 + this.Finished.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.Environment != null)
                    hash = hash * 59 + this.Environment.GetHashCode();
                if (this.Jobs != null)
                    hash = hash * 59 + this.Jobs.GetHashCode();
                return hash;
            }
        }


    }
}
