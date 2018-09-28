using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarframeSharp
{
    public struct SyndicateMission
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public string Activation { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("syndicate")]
        public string Syndicate { get; private set; }

        [JsonProperty("nodes")]
        public IEnumerable<string> Nodes { get; private set; }

        [JsonProperty("jobs")]
        public IEnumerable<string> Jobs { get; private set; }

        [JsonProperty("eta")]
        public string Eta { get; private set; }
    }
}
