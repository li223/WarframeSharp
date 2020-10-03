using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace WarframeSharp.Tests
{
    public class WarframeSharpClientTests
    {
        private WarframeSharpClient _client = new WarframeSharpClient();

        [Theory]
        [InlineData("ash")]
        [InlineData("nova")]
        [InlineData("ash prime")]
        [InlineData("rhino prime")]
        [InlineData("volt prime")]
        public async Task GetWarframeAsync_ValidQuery_ReturnWarframe(string query)
        {
            // Act
            var results = await _client.GetWarframeAsync(query);

            // Assert
            results.First()?.Name.ToLower().Should().Be(query);
        }

        [Fact]
        public async Task GetWarframesDataAsync_NoInput_ReturnWarframesData()
        {
            // Act
            var results = await _client.GetWarframesDataAsync();

            // Assert
            results.Should().NotBeNullOrEmpty();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetWorldStateDataAsync_ValidPlatform_ReturnWorldStateData(PlatformType platform)
        {
            // Act
            var results = await _client.GetWorldStateDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetNewsDataAsync_ValidPlatform_ReturnNewsData(PlatformType platform)
        {
            // Act
            var results = await _client.GetNewsDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetNightwaveStateDataAsync_ValidPlatform_ReturnNewsData(PlatformType platform)
        {
            // Act
            var results = await _client.GetNightwaveStateDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetEventsDataAsync_ValidPlatform_ReturnEventsData(PlatformType platform)
        {
            // Act
            var results = await _client.GetEventsDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetSortieDataAsync_ValidPlatform_ReturnSortieData(PlatformType platform)
        {
            // Act
            var results = await _client.GetSortieDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetSyndicateMissionsDataAsync_ValidPlatform_ReturnSyndicateMissionsData(PlatformType platform)
        {
            // Act
            var results = await _client.GetSyndicateMissionsDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetFissuresDataAsync_ValidPlatform_ReturnFissuresData(PlatformType platform)
        {
            // Act
            var results = await _client.GetFissuresDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetFlashSalesDataAsync_ValidPlatform_ReturnFlashSalesData(PlatformType platform)
        {
            // Act
            var results = await _client.GetFlashSalesDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetInvasionsDataAsync_ValidPlatform_ReturnInvasionsData(PlatformType platform)
        {
            // Act
            var results = await _client.GetInvasionsDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetVoidTraderDataAsync_ValidPlatform_ReturnVoidTraderData(PlatformType platform)
        {
            // Act
            var results = await _client.GetVoidTraderDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetDarvoDealsAsync_ValidPlatform_ReturnDarvoDeals(PlatformType platform)
        {
            // Act
            var results = await _client.GetDarvoDealsAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetSancturayDataAsync_ValidPlatform_ReturnSancturayData(PlatformType platform)
        {
            // Act
            var results = await _client.GetSancturayDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetConclaveChallengesDataAsync_ValidPlatform_ReturnConclaveChallengesData(
            PlatformType platform)
        {
            // Act
            var results = await _client.GetConclaveChallengesDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetCetusCycleDataAsync_ValidPlatform_ReturnCetusCycleData(PlatformType platform)
        {
            // Act
            var results = await _client.GetCetusCycleDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetEarthCycleDataAsync_ValidPlatform_ReturnEarthCycleData(PlatformType platform)
        {
            // Act
            var results = await _client.GetEarthCycleDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetConstructionProgressDataAsync_ValidPlatform_ReturnConstructionProgressData(
            PlatformType platform)
        {
            // Act
            var results = await _client.GetConstructionProgressDataAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetTimestampAsync_ValidPlatform_ReturnTimestamp(PlatformType platform)
        {
            // Act
            var results = await _client.GetTimestampAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }

        [Fact]
        public async Task GetWeaponsDataAsync_ValidPlatform_ReturnWeaponsData()
        {
            // Act
            var results = await _client.GetWeaponsDataAsync();

            // Assert
            results.Should().NotBeNull();
        }

        [Theory]
        [InlineData(PlatformType.PC)]
        [InlineData(PlatformType.PS4)]
        [InlineData(PlatformType.XB1)]
        [InlineData(PlatformType.SWI)]
        public async Task GetVallisCycleAsync_ValidPlatform_ReturnVallisCycle(PlatformType platform)
        {
            // Act
            var results = await _client.GetVallisCycleAsync(platform);

            // Assert
            results.Should().NotBeNull();
        }
    }
}