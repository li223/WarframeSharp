using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WarframeSharp
{
    /// <summary>
    /// World State Struct
    /// </summary>
    public class WorldState
    {
        /// <summary>
        /// World State Timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime WorldTimestamp { get; private set; }

        /// <summary>
        /// The current news
        /// </summary>
        [JsonProperty("news")]
        public IEnumerable<News> News { get; private set; }

        /// <summary>
        /// The current Events
        /// </summary>
        [JsonProperty("events")]
        public IEnumerable<Event> Events { get; private set; }

        /// <summary>
        /// The current Events
        /// </summary>
        [JsonProperty("alerts")]
        public IEnumerable<Alert> Alerts { get; private set; }

        /// <summary>
        /// The current Sortie
        /// </summary>
        [JsonProperty("sortie")]
        public Sortie Sortie { get; private set; }

        /// <summary>
        /// The current Syndicate Missions
        /// </summary>
        [JsonProperty("syndicateMissions")]
        public IEnumerable<SyndicateMission> SyndicateMissions { get; private set; }

        /// <summary>
        /// The current Fissures
        /// </summary>
        [JsonProperty("fissures")]
        public IEnumerable<Fissure> Fissure { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("globalUpgrades")]
        public IEnumerable<string> GlobalUpgrades { get; private set; }

        /// <summary>
        /// The current Flash Sales
        /// </summary>
        [JsonProperty("flashSales")]
        public IEnumerable<FlashSale> FlashSale { get; private set; }

        /// <summary>
        /// The current Invasions
        /// </summary>
        [JsonProperty("invasions")]
        public IEnumerable<Invasion> Invasions { get; private set; }

        /// <summary>
        /// The current Dark Sectors
        /// </summary>
        [JsonProperty("darkSectors"), Obsolete("Dark Sectors no longer exist")]
        public IEnumerable<DarkSector> DarkSectors { get; private set; }

        /// <summary>
        /// The Void Trader data
        /// </summary>
        [JsonProperty("voidTrader")]
        public VoidTrader VoidTrader { get; private set; }

        /// <summary>
        /// The current daily deals
        /// </summary>
        [JsonProperty("dailyDeals")]
        public IEnumerable<DailyDeal> DailyDeals { get; private set; }

        /// <summary>
        /// The Sancturay Data
        /// </summary>
        [JsonProperty("simaris")]
        public SimarisTarget Simaris { get; private set; }

        /// <summary>
        /// The current Conclave Challenges
        /// </summary>
        [JsonProperty("conclaveChallenges")]
        public IEnumerable<ConclaveChallenge> ConclaveChallenges { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("persistentEnemies")]
        public IEnumerable<string> PersistentEnemies { get; private set; }

        /// <summary>
        /// The current Earth Cycle Data
        /// </summary>
        [JsonProperty("earthCycle")]
        public EarthCycle EarthCycle { get; private set; }

        /// <summary>
        /// The current Cetus Cycle Data
        /// </summary>
        [JsonProperty("cetusCycle")]
        public CetusCycle CetusCycle { get; private set; }

        /// <summary>
        /// The current Vallis Cycle Data
        /// </summary>
        [JsonProperty("vallisCycle")]
        public VallisCycle VallisCycle { get; private set; }

        /// <summary>
        /// The current Conclassion Progress
        /// </summary>
        [JsonProperty("conclassionProgress")]
        public ConclassionProgress ConclassionProgress { get; private set; }

        /// <summary>
        /// Current Nightwave Alert
        /// </summary>
        [JsonProperty("nightwave")]
        public Nightwave Nightwave { get; private set; }
    }

    /// <summary>
    /// Conclassion Progress Struct
    /// </summary>
    public class ConclassionProgress
    {
        /// <summary>
        /// Conclassion Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Current fomorian progress
        /// </summary>
        [JsonProperty("fomorianProgress")]
        public double FomorianProgress { get; private set; }

        /// <summary>
        /// Current razorback progress
        /// </summary>
        [JsonProperty("razorbackProgress")]
        public double RazorbackProgress { get; private set; }

        /// <summary>
        /// Current progress of unknown projects
        /// </summary>
        [JsonProperty("unknownProgress")]
        public double UnknownProgress { get; private set; }
    }

    /// <summary>
    /// Earth Cycle Struct
    /// </summary>
    public class EarthCycle
    {
        /// <summary>
        /// Cycle Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Cycle Expiration
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime Expiry { get; private set; }

        /// <summary>
        /// If it is currently daytime or not
        /// </summary>
        [JsonProperty("isDay")]
        public bool IsDay { get; private set; }

        /// <summary>
        /// Time left until nighttime
        /// </summary>
        [JsonProperty("timeLeft")]
        public string TimeLeft { get; private set; }
    }

    /// <summary>
    /// Cetus Cycle Struct
    /// </summary>
    public class CetusCycle
    {
        /// <summary>
        /// Cycle Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Cycle Expiration
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime Expiry { get; private set; }

        /// <summary>
        /// If the data is for cetus or not
        /// </summary>
        [JsonProperty("isCetus")]
        public bool IsCetus { get; private set; }

        /// <summary>
        /// Time left until nighttime
        /// </summary>
        [JsonProperty("timeLeft")]
        public string TimeLeft { get; private set; }

        /// <summary>
        /// Short time string in minutes until Day/Night time
        /// </summary>
        [JsonProperty("shortString")]
        public string ShortString { get; private set; }
    }

    /// <summary>
    /// Vallis Cycle Struct
    /// </summary>
    public class VallisCycle
    {
        /// <summary>
        /// Cycle Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Cycle Expiration
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime Expiry { get; private set; }

        /// <summary>
        /// If the current cycle is the warm cycle or not
        /// </summary>
        [JsonProperty("isWarm")]
        public bool IsWarm { get; private set; }

        /// <summary>
        /// Time left until Warm/Cold
        /// </summary>
        [JsonProperty("timeLeft")]
        public string TimeLeft { get; private set; }

        /// <summary>
        /// Short time string in minutes until Warm/Cold
        /// </summary>
        [JsonProperty("shortString")]
        public string ShortString { get; private set; }
    }

    /// <summary>
    /// Simaris Struct
    /// </summary>
    public class SimarisTarget
    {
        /// <summary>
        /// The current Synthesis Target
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; private set; }

        /// <summary>
        /// If the current target is active
        /// </summary>
        [JsonProperty("isTargetActive")]
        public bool IsTargetActive { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("asString")]
        public string AsString { get; private set; }
    }

    /// <summary>
    /// Daily Deal Struct
    /// </summary>
    public class DailyDeal
    {
        /// <summary>
        /// The item the deal is for
        /// </summary>
        [JsonProperty("item")]
        public string Item { get; private set; }

        /// <summary>
        /// Timestamp of the deal's expiration
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime Expiry { get; private set; }

        /// <summary>
        /// Original price of the item
        /// </summary>
        [JsonProperty("originalPrice")]
        public int OriginalPrice { get; private set; }

        /// <summary>
        /// Current sale price of the item 
        /// </summary>
        [JsonProperty("salePrice")]
        public int SalePrice { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; private set; }

        /// <summary>
        /// Number of items sold
        /// </summary>
        [JsonProperty("sold")]
        public int Sold { get; private set; }

        /// <summary>
        /// Deal Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Time until deal is refreshed
        /// </summary>
        [JsonProperty("eta")]
        public string Eta { get; private set; }

        /// <summary>
        /// The current discount on the item
        /// </summary>
        [JsonProperty("discount")]
        public int Discount { get; private set; }
    }

    /// <summary>
    /// Void Trader Struct
    /// </summary>
    public class VoidTrader
    {
        /// <summary>
        /// Trader Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Timestamp of Trader Activation
        /// </summary>
        [JsonProperty("activation")]
        public DateTime Activation { get; private set; }

        /// <summary>
        /// Timestamp of Trader Expiration
        /// </summary>
        [JsonProperty("expiry")]
        public DateTime Expiry { get; private set; }

        /// <summary>
        /// Name of the Void Trader
        /// </summary>
        [JsonProperty("character")]
        public string Character { get; private set; }

        /// <summary>
        /// Where the trader is or is going to be
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; private set; }

        /// <summary>
        /// The trader's current inventory
        /// </summary>
        [JsonProperty("inventory")]
        public IEnumerable<VoidTraderItem> Inventory { get; private set; }

        /// <summary>
        /// Assigned Id
        /// </summary>
        [JsonProperty("psId")]
        public string PsId { get; private set; }

        /// <summary>
        /// If the trader is currently active
        /// </summary>
        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        /// <summary>
        /// Returns how long until the trader next arrives in human readable format
        /// </summary>
        [JsonProperty("startString")]
        public string StartString { get; private set; }

        /// <summary>
        /// Returns how long until the trader leaves in human readable format
        /// </summary>
        [JsonProperty("endString")]
        public string EndString { get; private set; }
    }

#pragma warning disable CS1591
    [Obsolete("Dark Sectors no longer exist")]
    public class DarkSector
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("isAlliance")]
        public bool IsAlliance { get; private set; }

        [JsonProperty("defenderName")]
        public string DefenderName { get; private set; }

        [JsonProperty("defenderDeployemntActivation")]
        public int DefenderDeployemntActivation { get; private set; }

        [JsonProperty("defenderMOTD")]
        public string DefenderMOTD { get; private set; }

        [JsonProperty("deployerName")]
        public string DeployerName { get; private set; }

        [JsonProperty("deployerClan")]
        public string DeployerClan { get; private set; }

        [JsonProperty("history")]
        public IEnumerable<DarkSector?> History { get; private set; }
    }

    /// <summary>
    /// An item in the void trader's inventory
    /// </summary>
    public class VoidTraderItem
    {
        /// <summary>
        /// The item name
        /// </summary>
        [JsonProperty("item")]
        public string Item { get; private set; }

        /// <summary>
        /// Ducat cost
        /// </summary>
        [JsonProperty("ducats")]
        public int Ducats { get; private set; }

        /// <summary>
        /// Credit Cost
        /// </summary>
        [JsonProperty("credits")]
        public int Credits { get; private set; }
    }

    public class Event : Alert { }
#pragma warning restore CS1591

    /// <summary>
    /// Alert Struct
    /// </summary>
    public class Alert
    {
        /// <summary>
        /// Alert/Event Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Alert/Event Activation
        /// </summary>
        [JsonProperty("activation")]
        public DateTime Activation { get; private set; }

        /// <summary>
        /// Alert/Event Expiration
        /// </summary>

        [JsonProperty("expiry")]
        public DateTime Expiry { get; private set; }

        /// <summary>
        /// Alert/Event Mission
        /// </summary>

        [JsonProperty("mission")]
        public Mission Mission { get; private set; }

        /// <summary>
        /// If the alert has expired or not
        /// </summary>
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        /// <summary>
        /// Time left on the alert
        /// </summary>
        [JsonProperty("eta")]
        public string Eta { get; private set; }

        /// <summary>
        /// Type of rewards
        /// </summary>
        [JsonProperty("rewardTypes")]
        public string[] RewardTypes { get; private set; }
    }

    /// <summary>
    /// Item Struct
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Item Count
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; private set; }

        /// <summary>
        /// Item Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
    }
}
