using BeatLeaderLib;
using BeatLeaderLib.Models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BeatLeaderLibTests
{
    public class Players
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetPlayer()
        {
            var beatLeaderApi = new BeatLeaderApi();
            var player = await beatLeaderApi.Player.GetPlayerByID("76561198187936410");
            Assert.IsTrue(player.Id == "76561198187936410");           
        }

        [Test]
        public async Task GetPlayerScores()
        {
            var beatLeaderApi = new BeatLeaderApi();
            var player = await beatLeaderApi.Player.GetPlayerScoresByID("76561198187936410");
            Assert.IsTrue(player.Data.Count > 5);
        }

        [Test]
        public async Task GetPlayerHistory()
        {
            var beatLeaderApi = new BeatLeaderApi();
            var player = await beatLeaderApi.Player.GetPlayerHistoryByID("3225556157461414");
            Assert.IsTrue(player.Count > 20);
        }

        [Test]
        public async Task GetPlayers()
        {
            var beatLeaderApi = new BeatLeaderApi();
            var players = await beatLeaderApi.Player.GetPlayers();
            Assert.IsTrue(players.Data.Count > 20);
        }
    }
}