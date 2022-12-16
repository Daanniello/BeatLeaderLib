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
            var beatLeaderClient = new BeatLeaderClient();
            var player = await beatLeaderClient.GetPlayerAsync("76561198187936410");
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