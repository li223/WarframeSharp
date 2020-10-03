﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Reward struct
    /// </summary>
    public struct Reward
    {
        /// <summary>
        /// Singular rewarded items (IE: Helments)
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<string> Items { get; private set; }

        /// <summary>
        /// Stackable rewarded items (IE: Nitan Extract)
        /// </summary>
        [JsonProperty("countedItems")]
        public IEnumerable<Item> CountedItems { get; private set; }

        /// <summary>
        /// Rewarded credits
        /// </summary>
        [JsonProperty("credits")]
        public int Credits { get; private set; }

        /// <summary>
        /// Reward name + credit reward
        /// </summary>
        [JsonProperty("asString")]
        public string AsString { get; private set; }

        /// <summary>
        /// Item name
        /// </summary>
        [JsonProperty("itemString")]
        public string ItemString { get; private set; }

        /// <summary>
        /// Image thumbnail
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("color")]
        public int Colour { get; private set; }
    }
}
