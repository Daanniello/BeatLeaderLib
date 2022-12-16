using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLib.Models
{
    public class PlayerScoresModel
    {
        public partial class PlayerScores
        {
            [JsonProperty("metadata")]
            public Metadata Metadata { get; set; }

            [JsonProperty("data")]
            public List<Datum> Data { get; set; }
        }

        public partial class Datum
        {
            [JsonProperty("myScore")]
            public object MyScore { get; set; }

            [JsonProperty("leaderboard")]
            public Leaderboard Leaderboard { get; set; }

            [JsonProperty("weight")]
            public double Weight { get; set; }

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
            public double Pp { get; set; }

            [JsonProperty("bonusPp")]
            public long BonusPp { get; set; }

            [JsonProperty("rank")]
            public long Rank { get; set; }

            [JsonProperty("countryRank")]
            public long CountryRank { get; set; }

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

            [JsonProperty("hmd")]
            public long Hmd { get; set; }

            [JsonProperty("leaderboardId")]
            public string LeaderboardId { get; set; }

            [JsonProperty("timeset")]
            public long Timeset { get; set; }

            [JsonProperty("timepost")]
            public long Timepost { get; set; }

            [JsonProperty("replaysWatched")]
            public long ReplaysWatched { get; set; }

            [JsonProperty("player")]
            public object Player { get; set; }

            [JsonProperty("scoreImprovement")]
            public ScoreImprovement ScoreImprovement { get; set; }

            [JsonProperty("rankVoting")]
            public object RankVoting { get; set; }

            [JsonProperty("metadata")]
            public object Metadata { get; set; }
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
            public double? Stars { get; set; }

            [JsonProperty("type")]
            public long Type { get; set; }

            [JsonProperty("njs")]
            public double Njs { get; set; }

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
        }

        public partial class ModifierValues
        {
            [JsonProperty("modifierId")]
            public long ModifierId { get; set; }

            [JsonProperty("da")]
            public double Da { get; set; }

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
            public double Bpm { get; set; }

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

        public partial class ScoreImprovement
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("timeset")]
            public string Timeset { get; set; }

            [JsonProperty("score")]
            public long Score { get; set; }

            [JsonProperty("accuracy")]
            public double Accuracy { get; set; }

            [JsonProperty("pp")]
            public double Pp { get; set; }

            [JsonProperty("bonusPp")]
            public long BonusPp { get; set; }

            [JsonProperty("rank")]
            public long Rank { get; set; }

            [JsonProperty("accRight")]
            public double AccRight { get; set; }

            [JsonProperty("accLeft")]
            public double AccLeft { get; set; }

            [JsonProperty("averageRankedAccuracy")]
            public double AverageRankedAccuracy { get; set; }

            [JsonProperty("totalPp")]
            public double TotalPp { get; set; }

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

        public partial class Metadata
        {
            [JsonProperty("itemsPerPage")]
            public long ItemsPerPage { get; set; }

            [JsonProperty("page")]
            public long Page { get; set; }

            [JsonProperty("total")]
            public long Total { get; set; }
        }
    }
}
