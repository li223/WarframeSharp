using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// The main Client Class
    /// </summary>
    public class WarframeSharpClient
    {
        private SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        private readonly string _baseQuery = "https://api.warframestat.us";
        private HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// The full response from each of the other methods, useful if you want all the data with only one call.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<WorldState?> GetWorldStateDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<WorldState>(content);
            }
            else return null;
        }

        /// <summary>
        /// Translated News items from the worldstate
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<IEnumerable<News>> GetNewsDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/news");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<News>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Events, such as Fomorian Attacks are included here
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<IEnumerable<Event>> GetEventsDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/events");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Event>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Description and rewards for Alerts
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<IEnumerable<Alert>> GetAlertsDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/alerts");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Alert>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Data about the missions for the current sortie
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<Sortie?> GetSortieDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/sortie");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Sortie>(content);
            }
            else return null;
        }

        /// <summary>
        /// Cycling through different nodes each day, these are a general listing of the nodes that each syndicate will use for the day.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<IEnumerable<SyndicateMission>> GetSyndicateMissionsDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/syndicateMissions");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<SyndicateMission>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Information about current Void Fissure missions
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<IEnumerable<Fissure>> GetFissuresDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/fissures");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Fissure>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Popular Deals, discounts, featured deals.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<IEnumerable<FlashSale>> GetFlashSalesDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/flashSales");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<FlashSale>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Data on invasion missions, such as estimated completion time, rewards, etc.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<IEnumerable<Invasion>> GetInvasionsDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/invasions");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Invasion>>(content);
            }
            else return null;
        }

        /// <summary>
        /// The endpoint this method uses is deprecated and only returns a joke response.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        [Obsolete("The endpoint this method uses is deprecated.", false)]
        public async Task<IEnumerable<DarkSector>> GetDarkSectorsDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/darkSector");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<DarkSector>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Information on the current Void Trader offerings, or when he will arrive.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<VoidTrader?> GetVoidTraderDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/voidTrader");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<VoidTrader>(content);
            }
            else return null;
        }

        /// <summary>
        /// Darvo's Daily Deal details
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<IEnumerable<DailyDeal>> GetDarvoDealsAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/dailyDeals");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<DailyDeal>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Status data for Simaris' Sanctuary
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<Simaris?> GetSancturayDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/simaris");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Simaris>(content);
            }
            else return null;
        }

        /// <summary>
        /// Data on each day and week's conclave challenges
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<IEnumerable<ConclaveChallenge>> GetConclaveChallengesDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/conclaveChallenges");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<ConclaveChallenge>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Data on the Day/night cycle for Cetus on earth
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<Cycle> GetCetusCycleDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/cetusCycle");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Cycle>(content);
            }
            else return null;
        }

        /// <summary>
        /// The current Earth day/night cycle progress.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<Cycle> GetEarthCycleDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/earth" +
                $"Cycle");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Cycle>(content);
            }
            else return null;
        }

        /// <summary>
        /// Construction percentages for showing how far constructed the enemy fleets are.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<ConstructionProgress?> GetConstructionProgressDataAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/constructionProgress");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ConstructionProgress>(content);
            }
            else return null;
        }

        /// <summary>
        /// The time that the worldstate was last generated
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for (options: pc, xb1, ps4)</param>
        /// <returns></returns>
        public async Task<string> GetTimestampAsync(string platform = "pc")
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform}/timestamp");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var headers = response.Headers;
                return JsonConvert.DeserializeObject<string>(content);
            }
            else return null;
        }

    }
}
