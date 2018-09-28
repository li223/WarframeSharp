using Newtonsoft.Json;

namespace WarframeSharp
{
    public struct FlashSale
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("eta")]
        public string Eta { get; private set; }

        [JsonProperty("isPopular")]
        public bool IsPopular { get; private set; }

        [JsonProperty("isFeatured")]
        public bool IsFeatured { get; private set; }

        [JsonProperty("premiumOverride")]
        public int PremiumOverride { get; private set; }

        [JsonProperty("discount")]
        public int Discount { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("item")]
        public string Item { get; private set; }
    }
}
