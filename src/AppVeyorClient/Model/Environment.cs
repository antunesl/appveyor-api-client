using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace AppVeyorClient.Model
{
    [DataContract]
    public partial class Environment : IEquatable<Environment>
    {
        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public EnvironmentProvider? Provider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        /// <param name="DeploymentEnvironmentId">DeploymentEnvironmentId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Provider">Provider.</param>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="ProjectsMode">0 is \&quot;Any project can be deployed to the environment\&quot; 1 is \&quot;Only selected projects can be deployed to the environment\&quot; 2 is \&quot;All except selected projects can be deployed to the environment\&quot;.</param>
        /// <param name="SecurityDescriptor">SecurityDescriptor.</param>
        public Environment(int? DeploymentEnvironmentId = default(int?), string Name = default(string), EnvironmentProvider? Provider = default(EnvironmentProvider?), int? AccountId = default(int?), int? ProjectsMode = default(int?), SecurityDescriptor SecurityDescriptor = default(SecurityDescriptor))
        {
            this.DeploymentEnvironmentId = DeploymentEnvironmentId;
            this.Name = Name;
            this.Provider = Provider;
            this.AccountId = AccountId;
            this.ProjectsMode = ProjectsMode;
            this.SecurityDescriptor = SecurityDescriptor;
        }

        /// <summary>
        /// Gets or Sets DeploymentEnvironmentId
        /// </summary>
        [DataMember(Name = "deploymentEnvironmentId", EmitDefaultValue = false)]
        public int? DeploymentEnvironmentId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
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
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public int? AccountId { get; set; }
        /// <summary>
        /// 0 is \&quot;Any project can be deployed to the environment\&quot; 1 is \&quot;Only selected projects can be deployed to the environment\&quot; 2 is \&quot;All except selected projects can be deployed to the environment\&quot;
        /// </summary>
        /// <value>0 is \&quot;Any project can be deployed to the environment\&quot; 1 is \&quot;Only selected projects can be deployed to the environment\&quot; 2 is \&quot;All except selected projects can be deployed to the environment\&quot;</value>
        [DataMember(Name = "projectsMode", EmitDefaultValue = false)]
        public int? ProjectsMode { get; set; }
        /// <summary>
        /// Gets or Sets SecurityDescriptor
        /// </summary>
        [DataMember(Name = "securityDescriptor", EmitDefaultValue = false)]
        public SecurityDescriptor SecurityDescriptor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20010Environment {\n");
            sb.Append("  DeploymentEnvironmentId: ").Append(DeploymentEnvironmentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ProjectsMode: ").Append(ProjectsMode).Append("\n");
            sb.Append("  SecurityDescriptor: ").Append(SecurityDescriptor).Append("\n");
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
            return this.Equals(obj as Environment);
        }

        /// <summary>
        /// Returns true if InlineResponse20010Environment instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20010Environment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Environment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.DeploymentEnvironmentId == other.DeploymentEnvironmentId ||
                    this.DeploymentEnvironmentId != null &&
                    this.DeploymentEnvironmentId.Equals(other.DeploymentEnvironmentId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
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
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) &&
                (
                    this.ProjectsMode == other.ProjectsMode ||
                    this.ProjectsMode != null &&
                    this.ProjectsMode.Equals(other.ProjectsMode)
                ) &&
                (
                    this.SecurityDescriptor == other.SecurityDescriptor ||
                    this.SecurityDescriptor != null &&
                    this.SecurityDescriptor.Equals(other.SecurityDescriptor)
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
                if (this.DeploymentEnvironmentId != null)
                    hash = hash * 59 + this.DeploymentEnvironmentId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.ProjectsMode != null)
                    hash = hash * 59 + this.ProjectsMode.GetHashCode();
                if (this.SecurityDescriptor != null)
                    hash = hash * 59 + this.SecurityDescriptor.GetHashCode();
                return hash;
            }
        }


    }
}
