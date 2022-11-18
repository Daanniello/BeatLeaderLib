using BeatLeaderLib;
using BeatLeaderLib.Models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BeatLeaderLibTests
{
    public class Leaderboard
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetLeaderboardByID()
        {
            var beatLeaderApi = new BeatLeaderApi();
            var leaderboard = await beatLeaderApi.Leaderboard.GetLeaderboardByID("20d0bx91");
            Assert.IsTrue(leaderboard.Id == "20d0bx91");           
        }

        [Test]
        public async Task GetLeaderboardByHash()
        {
            var beatLeaderApi = new BeatLeaderApi();
            var leaderboard = await beatLeaderApi.Leaderboard.GetLeaderboardByHash("4E19C93FF2D7E086536AEAB2F551C2E184160640");
            Assert.IsTrue(leaderboard.Song.Hash == "4E19C93FF2D7E086536AEAB2F551C2E184160640");
        }
        [Test]
        public async Task GetLeaderboards()
        {
            var beatLeaderApi = new BeatLeaderApi();
            var leaderboard = await beatLeaderApi.Leaderboard.GetLeaderboards(count: 11);
            Assert.IsTrue(leaderboard.Data.Count > 10);
        }

        [Test]
        public async Task GetLeaderboardStatistic()
        {
            var beatLeaderApi = new BeatLeaderApi();
            var leaderboard = await beatLeaderApi.Leaderboard.GetLeaderboardStatistic("20d0bx91");
            Assert.IsTrue(leaderboard != null);
        }
    }
}