using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WebSocketSharp;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLibWebSocket
{
    public class WebSocket
    {
        public WebSocketSharp.WebSocket webSocket = new WebSocketSharp.WebSocket("wss://api.beatleader.xyz/scores");
        public event EventHandler<ScoreFeedModel> OnPlayReceived;
        public event EventHandler OnDisconnect;
        public bool shouldReconnect = true;

        public WebSocket()
        {

        }

        public void Connect()
        {
            webSocket.OnMessage += _webSocket_OnMessage;
            webSocket.OnClose += _webSocket_OnDisconnect;
            webSocket.Connect();
            WebsocketTimer();
        }

        public void Disconnect()
        {
            shouldReconnect = false;
            webSocket.Close();
        }

        private async void WebsocketTimer()
        {
            while (shouldReconnect)
            {
                await Task.Delay(10000);
                if (!webSocket.IsAlive)
                {
                    webSocket.Connect();
                }
            }
        }

        private class ScoreSaberWebSocketModel
        {
            [JsonProperty("commandName")]
            public string CommandName { get; set; }
        }

        private void _webSocket_OnMessage(object sender, MessageEventArgs e)
        {
            try
            {
                var scoreFeedData = JsonConvert.DeserializeObject<ScoreFeedModel>(e.Data);
                if(scoreFeedData != null) PlayReceived(scoreFeedData);
            }
            catch
            {
                return;
            }
        }

        protected virtual void PlayReceived(ScoreFeedModel e)
        {
            EventHandler<ScoreFeedModel> handler = OnPlayReceived;
            handler?.Invoke(this, e);
        }

        private void _webSocket_OnDisconnect(object sender, CloseEventArgs e)
        {
            EventHandler handler = OnDisconnect;
            handler?.Invoke(this, e);
        }
    }

    public partial class ScoreFeedModel
    {
        [JsonProperty("myScore")]
        public object MyScore { get; set; }

        [JsonProperty("leaderboard")]
        public Leaderboard Leaderboard { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("accLeft")]
        public double AccLeft { get; set; }

        [JsonProperty("accRight")]
        public double AccRight { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("baseScore")]
        public long BaseScore { get; set; }

        [JsonProperty("modifiedScore")]
        public long ModifiedScore { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("pp")]
        public long Pp { get; set; }

        [JsonProperty("bonusPp")]
        public long BonusPp { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("countryRank")]
        public long CountryRank { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fcAccuracy")]
        public double FcAccuracy { get; set; }

        [JsonProperty("fcPp")]
        public long FcPp { get; set; }

        [JsonProperty("replay")]
        public Uri Replay { get; set; }

        [JsonProperty("modifiers")]
        public string Modifiers { get; set; }

        [JsonProperty("badCuts")]
        public long BadCuts { get; set; }

        [JsonProperty("missedNotes")]
        public long MissedNotes { get; set; }

        [JsonProperty("bombCuts")]
        public long BombCuts { get; set; }

        [JsonProperty("wallsHit")]
        public long WallsHit { get; set; }

        [JsonProperty("pauses")]
        public long Pauses { get; set; }

        [JsonProperty("fullCombo")]
        public bool FullCombo { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("maxCombo")]
        public long MaxCombo { get; set; }

        [JsonProperty("maxStreak")]
        public long MaxStreak { get; set; }

        [JsonProperty("hmd")]
        public long Hmd { get; set; }

        [JsonProperty("controller")]
        public long Controller { get; set; }

        [JsonProperty("leaderboardId")]
        public string LeaderboardId { get; set; }

        [JsonProperty("timeset")]
        public long Timeset { get; set; }

        [JsonProperty("timepost")]
        public long Timepost { get; set; }

        [JsonProperty("replaysWatched")]
        public long ReplaysWatched { get; set; }

        [JsonProperty("playCount")]
        public long PlayCount { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("scoreImprovement")]
        public ScoreImprovement ScoreImprovement { get; set; }

        [JsonProperty("rankVoting")]
        public object RankVoting { get; set; }

        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("offsets")]
        public Offsets Offsets { get; set; }
    }

    public partial class Leaderboard
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("song")]
        public Song Song { get; set; }

        [JsonProperty("difficulty")]
        public Difficulty Difficulty { get; set; }

        [JsonProperty("scores")]
        public object Scores { get; set; }

        [JsonProperty("changes")]
        public object Changes { get; set; }

        [JsonProperty("qualification")]
        public object Qualification { get; set; }

        [JsonProperty("reweight")]
        public object Reweight { get; set; }

        [JsonProperty("leaderboardGroup")]
        public object LeaderboardGroup { get; set; }

        [JsonProperty("plays")]
        public long Plays { get; set; }
    }

    public partial class Difficulty
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("mode")]
        public long Mode { get; set; }

        [JsonProperty("difficultyName")]
        public string DifficultyName { get; set; }

        [JsonProperty("modeName")]
        public string ModeName { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("modifierValues")]
        public ModifierValues ModifierValues { get; set; }

        [JsonProperty("nominatedTime")]
        public long NominatedTime { get; set; }

        [JsonProperty("qualifiedTime")]
        public long QualifiedTime { get; set; }

        [JsonProperty("rankedTime")]
        public long RankedTime { get; set; }

        [JsonProperty("stars")]
        public object Stars { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("njs")]
        public long Njs { get; set; }

        [JsonProperty("nps")]
        public double Nps { get; set; }

        [JsonProperty("notes")]
        public long Notes { get; set; }

        [JsonProperty("bombs")]
        public long Bombs { get; set; }

        [JsonProperty("walls")]
        public long Walls { get; set; }

        [JsonProperty("maxScore")]
        public long MaxScore { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }
    }

    public partial class ModifierValues
    {
        [JsonProperty("modifierId")]
        public long ModifierId { get; set; }

        [JsonProperty("da")]
        public long Da { get; set; }

        [JsonProperty("fs")]
        public double Fs { get; set; }

        [JsonProperty("ss")]
        public double Ss { get; set; }

        [JsonProperty("sf")]
        public double Sf { get; set; }

        [JsonProperty("gn")]
        public double Gn { get; set; }

        [JsonProperty("na")]
        public double Na { get; set; }

        [JsonProperty("nb")]
        public double Nb { get; set; }

        [JsonProperty("nf")]
        public double Nf { get; set; }

        [JsonProperty("no")]
        public double No { get; set; }

        [JsonProperty("pm")]
        public long Pm { get; set; }

        [JsonProperty("sc")]
        public long Sc { get; set; }

        [JsonProperty("sa")]
        public long Sa { get; set; }
    }

    public partial class Song
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("subName")]
        public string SubName { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("mapper")]
        public string Mapper { get; set; }

        [JsonProperty("mapperId")]
        public long MapperId { get; set; }

        [JsonProperty("coverImage")]
        public Uri CoverImage { get; set; }

        [JsonProperty("downloadUrl")]
        public Uri DownloadUrl { get; set; }

        [JsonProperty("bpm")]
        public long Bpm { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("uploadTime")]
        public long UploadTime { get; set; }

        [JsonProperty("difficulties")]
        public List<Difficulty> Difficulties { get; set; }
    }

    public partial class Offsets
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("frames")]
        public long Frames { get; set; }

        [JsonProperty("notes")]
        public long Notes { get; set; }

        [JsonProperty("walls")]
        public long Walls { get; set; }

        [JsonProperty("heights")]
        public long Heights { get; set; }

        [JsonProperty("pauses")]
        public long Pauses { get; set; }
    }

    public partial class Player
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("pp")]
        public double Pp { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("countryRank")]
        public long CountryRank { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("socials")]
        public object Socials { get; set; }

        [JsonProperty("patreonFeatures")]
        public object PatreonFeatures { get; set; }

        [JsonProperty("profileSettings")]
        public ProfileSettings ProfileSettings { get; set; }

        [JsonProperty("clans")]
        public object Clans { get; set; }
    }

    public partial class ProfileSettings
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("bio")]
        public object Bio { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("effectName")]
        public object EffectName { get; set; }

        [JsonProperty("profileAppearance")]
        public object ProfileAppearance { get; set; }

        [JsonProperty("hue")]
        public long Hue { get; set; }

        [JsonProperty("saturation")]
        public long Saturation { get; set; }

        [JsonProperty("leftSaberColor")]
        public object LeftSaberColor { get; set; }

        [JsonProperty("rightSaberColor")]
        public object RightSaberColor { get; set; }

        [JsonProperty("profileCover")]
        public object ProfileCover { get; set; }
    }

    public partial class ScoreImprovement
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("timeset")]
        public string Timeset { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("accuracy")]
        public long Accuracy { get; set; }

        [JsonProperty("pp")]
        public long Pp { get; set; }

        [JsonProperty("bonusPp")]
        public long BonusPp { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("accRight")]
        public long AccRight { get; set; }

        [JsonProperty("accLeft")]
        public long AccLeft { get; set; }

        [JsonProperty("averageRankedAccuracy")]
        public long AverageRankedAccuracy { get; set; }

        [JsonProperty("totalPp")]
        public long TotalPp { get; set; }

        [JsonProperty("totalRank")]
        public long TotalRank { get; set; }

        [JsonProperty("badCuts")]
        public long BadCuts { get; set; }

        [JsonProperty("missedNotes")]
        public long MissedNotes { get; set; }

        [JsonProperty("bombCuts")]
        public long BombCuts { get; set; }

        [JsonProperty("wallsHit")]
        public long WallsHit { get; set; }

        [JsonProperty("pauses")]
        public long Pauses { get; set; }
    }
}
