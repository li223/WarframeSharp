using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarframeSharp
{
    public struct Reward
    {
        [JsonProperty("items")]
        public IEnumerable<Item> Items { get; private set; }

        [JsonProperty("countedItems")]
        public IEnumerable<Item> CountedItems { get; private set; }

        [JsonProperty("credits")]
        public int Credits { get; private set; }

        [JsonProperty("asString")]
        public string AsString { get; private set; }

        [JsonProperty("itemString")]
        public string ItemString { get; private set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; private set; }

        [JsonProperty("color")]
        public int Colour { get; private set; }
    }
}
