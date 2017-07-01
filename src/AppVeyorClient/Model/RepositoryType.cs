using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace AppVeyorClient.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RepositoryTypeEnum
    {

        /// <summary>
        /// Enum BitBucket for "bitBucket"
        /// </summary>
        [EnumMember(Value = "bitBucket")]
        BitBucket,

        /// <summary>
        /// Enum Git for "git"
        /// </summary>
        [EnumMember(Value = "git")]
        Git,

        /// <summary>
        /// Enum GitHub for "gitHub"
        /// </summary>
        [EnumMember(Value = "gitHub")]
        GitHub,

        /// <summary>
        /// Enum GitLab for "gitLab"
        /// </summary>
        [EnumMember(Value = "gitLab")]
        GitLab,

        /// <summary>
        /// Enum Kiln for "kiln"
        /// </summary>
        [EnumMember(Value = "kiln")]
        Kiln,

        /// <summary>
        /// Enum Mercurial for "mercurial"
        /// </summary>
        [EnumMember(Value = "mercurial")]
        Mercurial,

        /// <summary>
        /// Enum Stash for "stash"
        /// </summary>
        [EnumMember(Value = "stash")]
        Stash,

        /// <summary>
        /// Enum Subversion for "subversion"
        /// </summary>
        [EnumMember(Value = "subversion")]
        Subversion,

        /// <summary>
        /// Enum Vso for "vso"
        /// </summary>
        [EnumMember(Value = "vso")]
        Vso
    }

    /// <summary>
    /// Gets or Sets RepositoryScm
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RepositoryScmEnum
    {

        /// <summary>
        /// Enum Git for "git"
        /// </summary>
        [EnumMember(Value = "git")]
        Git,

        /// <summary>
        /// Enum Mercurial for "mercurial"
        /// </summary>
        [EnumMember(Value = "mercurial")]
        Mercurial,

        /// <summary>
        /// Enum Subversion for "subversion"
        /// </summary>
        [EnumMember(Value = "subversion")]
        Subversion
    }

}
