using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Component Struct
    /// </summary>
    public struct Component
    {
        /// <summary>
        /// Url path of the component
        /// </summary>
        [JsonProperty("uniqueName")]
        public string UniqueName { get; private set; }

        /// <summary>
        /// Component name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Component description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Component item count
        /// </summary>
        [JsonProperty("itemCount")]
        public int ItemCount { get; private set; }

        /// <summary>
        /// If the component is tradable or not
        /// </summary>
        [JsonProperty("tradable")]
        public bool IsTradable { get; private set; }

        /// <summary>
        /// Component image name
        /// </summary>
        [JsonProperty("imageName")]
        public string ImageName { get; private set; }
    }
}
