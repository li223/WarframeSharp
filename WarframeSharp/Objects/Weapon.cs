using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Weapon Struct
    /// </summary>
    public struct Weapon
    {
        /// <summary>
        /// Url path of the weapon
        /// </summary>
        [JsonProperty("uniqueName")]
        public string UniqueName { get; private set; }

        /// <summary>
        /// The weapon's name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Seconds needed between shots
        /// </summary>
        [JsonProperty("secondsPerShot")]
        public double SecondsPerShot { get; private set; }

        /// <summary>
        /// Damage Per Shot
        /// </summary>
        [JsonProperty("damagePerShot")]
        public double[] DamagePerShot { get; private set; }

        /// <summary>
        /// The weapon's reload time
        /// </summary>
        [JsonProperty("reloadTime")]
        public double ReloadTime { get; private set; }

        /// <summary>
        /// The weapon's magazine size
        /// </summary>
        [JsonProperty("magazineSize")]
        public int? MagazineSize { get; private set; }

        /// <summary>
        /// The weapon's damage per second
        /// </summary>
        [JsonProperty("damagePerSecond")]
        public int DamagePerSecond { get; private set; }

        /// <summary>
        /// The weapon's description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// The weapon's accuracy
        /// </summary>
        [JsonProperty("accuracy")]
        public double? Accuracy { get; private set; }

        /// <summary>
        /// The weapon's critical chance
        /// </summary>
        [JsonProperty("criticalChance")]
        public double CriticalChance { get; private set; }

        /// <summary>
        /// The weapon's critical multiplier
        /// </summary>
        [JsonProperty("criticalMultiplier")]
        public double CritMultiplier { get; private set; }

        /// <summary>
        /// The weapon's proc chance
        /// </summary>
        [JsonProperty("procChance")]
        public double ProcChance { get; private set; }

        /// <summary>
        /// The weapon's fire rate
        /// </summary>
        [JsonProperty("fireRate")]
        public double? FireRate { get; private set; }

        /// <summary>
        /// The weapon's charge attack
        /// </summary>
        [JsonProperty("chargeAttack")]
        public int? ChargeAttack { get; private set; }

        /// <summary>
        /// The weapon's spin attack
        /// </summary>
        [JsonProperty("spinAttack")]
        public int? SpinAttack { get; private set; }

        /// <summary>
        /// The weapon's leap attack
        /// </summary>
        [JsonProperty("leapAttack")]
        public int? LeapAttack { get; private set; }

        /// <summary>
        /// The weapon's wall attack
        /// </summary>
        [JsonProperty("wallAttack")]
        public int? WallAttack { get; private set; }

        /// <summary>
        /// The weapon's slots
        /// </summary>
        [JsonProperty("slot")]
        public int Slots { get; private set; }

        /// <summary>
        /// Is a sentinel weapon
        /// </summary>
        [JsonProperty("sentinel")]
        public bool IsSentinel { get; private set; }

        /// <summary>
        /// The weapon's omega attenuation
        /// </summary>
        [JsonProperty("omegaAttenuation")]
        public double OmegaAttenuation { get; private set; }

        /// <summary>
        /// The weapon's type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The weapon's build price
        /// </summary>
        [JsonProperty("buildPrice")]
        public int BuildPrice { get; private set; }

        /// <summary>
        /// The weapon's build time
        /// </summary>
        [JsonProperty("buildTime")]
        public int BuildTime { get; private set; }

        /// <summary>
        /// The weapon's skip build time price
        /// </summary>
        [JsonProperty("skipBuildTimePrice")]
        public int SkipBuildTimePrice { get; private set; }

        /// <summary>
        /// Quantity unpon completion 
        /// </summary>
        [JsonProperty("buildQuantity")]
        public int BuildQuantity { get; private set; }

        /// <summary>
        /// Whether the blueprint is consumed upon building or not
        /// </summary>
        [JsonProperty("consumeOnBuild")]
        public bool IsConsumedOnBuild { get; private set; }

        /// <summary>
        /// The weapon's components
        /// </summary>
        [JsonProperty("components")]
        public IEnumerable<Component> Components { get; private set; }

        /// <summary>
        /// The weapon's image name
        /// </summary>
        [JsonProperty("imageName")]
        public string ImageName { get; private set; }

        /// <summary>
        /// The weapon's category
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; private set; }

        /// <summary>
        /// If the weapon can be traded or not
        /// </summary>
        [JsonProperty("tradable")]
        public bool IsTradable { get; private set; }

        /// <summary>
        /// The weapon's patch logs
        /// </summary>
        [JsonProperty("patchlogs")]
        public IEnumerable<Patchlog> Patchlogs { get; private set; }

        /// <summary>
        /// The weapon's channeling cost
        /// </summary>
        [JsonProperty("channeling")]
        public double ChannelingCost { get; private set; }

        /// <summary>
        /// The weapon's damage
        /// </summary>
        [JsonProperty("damage")]
        public string Damage { get; private set; }

        /// <summary>
        /// The weapon's damage types
        /// </summary>
        [JsonProperty("damageTypes")]
        public Dictionary<string, double> DamageTypes { get; private set; }

        /// <summary>
        /// The weapon's market cost
        /// </summary>
        [JsonProperty("marketCost")]
        public int? MarketCost { get; private set; }

        /// <summary>
        /// The weapon's polarities
        /// </summary>
        [JsonProperty("polarities")]
        public string[] Polarities { get; private set; }

        /// <summary>
        /// The weapon's stance polarity
        /// </summary>
        [JsonProperty("stancePolarity")]
        public string StancePolarity { get; private set; }

        /// <summary>
        /// The weapon's tags
        /// </summary>
        [JsonProperty("tags")]
        public string[] Tags { get; private set; }

        /// <summary>
        /// If the weapon is vaulted or not
        /// </summary>
        [JsonProperty("vaulted")]
        public bool IsVaulted { get; private set; }

        /// <summary>
        /// The weapon's wikia thumbnail
        /// </summary>
        [JsonProperty("wikiaThumbnail")]
        public string WikiaThumbnail { get; private set; }

        /// <summary>
        /// The weapon's wikia url
        /// </summary>
        [JsonProperty("wikiaUrl")]
        public string WikiaUrl { get; private set; }

        /// <summary>
        /// The weapon's riven disposition
        /// </summary>
        [JsonProperty("disposition")]
        public int RivenDisposition { get; private set; }

        /// <summary>
        /// Required mastery rank to use the weapon
        /// </summary>
        [JsonProperty("masteryReq")]
        public int MasteryRankRequirement { get; private set; }

        /// <summary>
        /// Weapon subtype
        /// </summary>
        [JsonProperty("subtype")]
        public string Subtype { get; private set; }

        /// <summary>
        /// The weapon attack type (melee or ranged)
        /// </summary>
        [JsonProperty("trigger")]
        public string Trigger { get; private set; }

        /// <summary>
        /// Type of projectile fired
        /// </summary>
        [JsonProperty("projectile")]
        public string Projectile { get; private set; }

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
        /// Weapon magazine size
        /// </summary>
        [JsonProperty("magazine")]
        public int? Magazine { get; private set; }

        /// <summary>
        /// Weapon ammo type
        /// </summary>
        [JsonProperty("ammo")]
        public string Ammo { get; private set; }

        /// <summary>
        /// Weapon reload speed
        /// </summary>
        [JsonProperty("reload")]
        public double Reload { get; private set; }

        /// <summary>
        /// Weapon impact value
        /// </summary>
        [JsonProperty("impact")]
        public double? Impact { get; private set; }

        /// <summary>
        /// Weapon puncture value
        /// </summary>
        [JsonProperty("puncture")]
        public double? Puncture { get; private set; }

        /// <summary>
        /// Weapon slash value
        /// </summary>
        [JsonProperty("slash")]
        public double? Slash { get; private set; }

        /// <summary>
        /// Weapon Status Chance
        /// </summary>
        [JsonProperty("status_chance")]
        public double? StatusChance { get; private set; }

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
