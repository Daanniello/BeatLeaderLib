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
            var websocket = beatLeaderClient.GetWebsocket();
            websocket.Connect();
            websocket.OnPlayReceived += Websocket_OnPlayReceived;
            await Task.Delay(5000);
            websocket.Disconnect();
            await Task.Delay(5000);
            websocket.Connect();
            await Task.Delay(5000);

        }

        private void Websocket_OnPlayReceived(object? sender, BeatLeaderLibWebSocket.ScoreFeedModel e)
        {
            var data = e;
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