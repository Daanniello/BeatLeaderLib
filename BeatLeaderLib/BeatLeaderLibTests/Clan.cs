using BeatLeaderLib;
using BeatLeaderLib.Models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BeatLeaderLibTests
{
    public class Clan
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetClan()
        {
            var beatLeaderApi = new BeatLeaderApi();
            var clan = await beatLeaderApi.Clan.GetClan();
            Assert.IsTrue(clan.Data.Count > 5);           
        }
    }
}