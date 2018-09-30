using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Weapon Struct
    /// </summary>
    public struct Weapon
    {
        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("regex")]
        public string Regex { get; private set; }

        /// <summary>
        /// The weapon's name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Required mastery rank to use the weapon
        /// </summary>
        [JsonProperty("mr")]
        public int MasteryRank { get; private set; }

        /// <summary>
        /// Weapon type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// Weapon subtype
        /// </summary>
        [JsonProperty("subtype")]
        public string Subtype { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("trigger")]
        public string Trigger { get; private set; }

        /// <summary>
        /// Type of projectile fired
        /// </summary>
        [JsonProperty("projectile")]
        public string Projectile { get; private set; }

        /// <summary>
        /// Rate of fire
        /// </summary>
        [JsonProperty("rate")]
        public int Rate { get; private set; }

        /// <summary>
        /// Weapon projectile flight speed
        /// </summary>
        [JsonProperty("flight")]
        public string Flight { get; private set; }

        /// <summary>
        /// Weapon range
        /// </summary>
        [JsonProperty("range")]
        public string Range { get; private set; }

        /// <summary>
        /// How noisy the weapon is
        /// </summary>
        [JsonProperty("noise")]
        public string Noise { get; private set; }

        /// <summary>
        /// Weapon accuracy
        /// </summary>
        [JsonProperty("accuracy")]
        public int Accuracy { get; private set; }

        /// <summary>
        /// Weapon magazine size
        /// </summary>
        [JsonProperty("magazine")]
        public int Magazine { get; private set; }

        /// <summary>
        /// Weapon ammo type
        /// </summary>
        [JsonProperty("ammo")]
        public string Ammo { get; private set; }

        /// <summary>
        /// Weapon reload speed
        /// </summary>
        [JsonProperty("reload")]
        public string Reload { get; private set; }

        /// <summary>
        /// Weapons Riven Disposition
        /// </summary>
        [JsonProperty("riven_disposition")]
        public string RivenDisposition { get; private set; }

        /// <summary>
        /// Weapon damage
        /// </summary>
        [JsonProperty("damage")]
        public string Damage { get; private set; }

        /// <summary>
        /// Weapon impact value
        /// </summary>
        [JsonProperty("impact")]
        public string Impact { get; private set; }

        /// <summary>
        /// Weapon puncture value
        /// </summary>
        [JsonProperty("puncture")]
        public string Puncture { get; private set; }

        /// <summary>
        /// Weapon slash value
        /// </summary>
        [JsonProperty("slash")]
        public string Slash { get; private set; }

        /// <summary>
        /// Weapon Critical Chance
        /// </summary>
        [JsonProperty("crit_chance")]
        public string CritChance { get; private set; }

        /// <summary>
        /// Weapon Critical Multiplyer
        /// </summary>
        [JsonProperty("crit_mult")]
        public string CriticalMultiplyer { get; private set; }

        /// <summary>
        /// Weapon Status Chance
        /// </summary>
        [JsonProperty("status_chance")]
        public string StatusChance { get; private set; }

        /// <summary>
        /// Weapon polarities
        /// </summary>
        [JsonProperty("polarities")]
        public string Polarities { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; private set; }
    }
}
