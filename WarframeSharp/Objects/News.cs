using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarframeSharp
{
    /// <summary>
    /// News class
    /// </summary>
    public class News
    {
        /// <summary>
        /// News Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// News message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; private set; }

        /// <summary>
        /// News link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; private set; }

        /// <summary>
        /// News image link
        /// </summary>
        [JsonProperty("imageLink")]
        public string ImageLink { get; private set; }

        /// <summary>
        /// Is priority news or not
        /// </summary>
        [JsonProperty("priority")]
        public bool IsPriority { get; private set; }

        /// <summary>
        /// Date the news was announced
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; private set; }

        /// <summary>
        /// How long ago from now it was posted
        /// </summary>
        [JsonProperty("eta")]
        public string Eta { get; private set; }

        /// <summary>
        /// Is an update
        /// </summary>
        [JsonProperty("update")]
        public bool IsUpdate { get; private set; }

        /// <summary>
        /// Is about prime access
        /// </summary>
        [JsonProperty("primeAccess")]
        public bool IsPrimeAccess { get; private set; }

        /// <summary>
        /// Is about a stream
        /// </summary>
        [JsonProperty("stream")]
        public bool IsStream { get; private set; }

        /// <summary>
        /// Language translations
        /// </summary>
        [JsonProperty("translations")]
        public Dictionary<string, string> Translations { get; private set; }

        /// <summary>
        /// News in markdown format
        /// </summary>
        [JsonProperty("asString")]
        public string AsString { get; private set; }
    }
}
