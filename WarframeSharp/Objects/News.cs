using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarframeSharp
{
    public struct News
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("message")]
        public string Message { get; private set; }

        [JsonProperty("link")]
        public string Link { get; private set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; private set; }

        [JsonProperty("priority")]
        public bool IsPriority { get; private set; }

        [JsonProperty("date")]
        public string Date { get; private set; }

        [JsonProperty("eta")]
        public string Eta { get; private set; }

        [JsonProperty("update")]
        public bool IsUpdate { get; private set; }

        [JsonProperty("primeAccess")]
        public bool IsPrimeAccess { get; private set; }

        [JsonProperty("stream")]
        public bool IsStream { get; private set; }

        [JsonProperty("translations")]
        public Dictionary<string, string> Translations { get; private set; }

        [JsonProperty("asString")]
        public string AsString { get; private set; }
    }
}
