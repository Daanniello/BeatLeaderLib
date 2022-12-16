using BeatLeaderLib;
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
            var beatLeaderApi = new BeatLeaderClient();
            var player = await beatLeaderApi.GetPlayerAsync("76561198187936410");
            Assert.IsTrue(player.Id == "76561198187936410");           
        }

        [Test]
        public async Task GetPlayerScores()
        {

        }

        [Test]
        public async Task GetPlayerHistory()
        {

        }

        [Test]
        public async Task GetPlayers()
        {

        }
    }
}