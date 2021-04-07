using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Flash sale class
    /// </summary>
    public class FlashSale
    {
        /// <summary>
        /// Flash sale Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// If the sale has expired or not
        /// </summary>
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("eta")]
        public string Eta { get; private set; }

        /// <summary>
        /// If the deal is popular or not
        /// </summary>
        [JsonProperty("isPopular")]
        public bool IsPopular { get; private set; }

        /// <summary>
        /// If the deal is being featured
        /// </summary>
        [JsonProperty("isFeatured")]
        public bool IsFeatured { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("premiumOverride")]
        public int PremiumOverride { get; private set; }

        /// <summary>
        /// Current item discount
        /// </summary>
        [JsonProperty("discount")]
        public int Discount { get; private set; }

        /// <summary>
        /// Timestamp of deal expiration
        /// </summary>
        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        /// <summary>
        /// The item being offered
        /// </summary>
        [JsonProperty("item")]
        public string Item { get; private set; }
    }
}
