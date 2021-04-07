using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Patchlog class
    /// </summary>
    public class Patchlog
    {
        /// <summary>
        /// Patchlog title
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; private set; }

        /// <summary>
        /// Date of the patch release
        /// </summary>
        [JsonProperty("date")]
        public string? Date { get; private set; }

        /// <summary>
        /// Forum url
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; private set; }

        /// <summary>
        /// Patch image url
        /// </summary>
        [JsonProperty("imgUrl")]
        public string? ImageUrl { get; private set; }

        /// <summary>
        /// Game additions
        /// </summary>
        [JsonProperty("additions")]
        public string? Additions { get; private set; }

        /// <summary>
        /// Game changes
        /// </summary>
        [JsonProperty("changes")]
        public string? Changes { get; private set; }

        /// <summary>
        /// Game fixes
        /// </summary>
        [JsonProperty("fixes")]
        public string? Fixes { get; private set; }
    }
}
