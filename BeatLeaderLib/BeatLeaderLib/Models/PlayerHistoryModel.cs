using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeatLeaderLib.Models
{
    public class PlayerHistoryModel
    {
        public partial class PlayerHistory
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("timestamp")]
            public long Timestamp { get; set; }

            [JsonProperty("playerId")]
            public string PlayerId { get; set; }

            [JsonProperty("pp")]
            public double Pp { get; set; }

            [JsonProperty("rank")]
            public long Rank { get; set; }

            [JsonProperty("countryRank")]
            public long CountryRank { get; set; }

            [JsonProperty("totalScore")]
            public long TotalScore { get; set; }

            [JsonProperty("totalUnrankedScore")]
            public long TotalUnrankedScore { get; set; }

            [JsonProperty("totalRankedScore")]
            public long TotalRankedScore { get; set; }

            [JsonProperty("lastScoreTime")]
            public long LastScoreTime { get; set; }

            [JsonProperty("lastUnrankedScoreTime")]
            public long LastUnrankedScoreTime { get; set; }

            [JsonProperty("lastRankedScoreTime")]
            public long LastRankedScoreTime { get; set; }

            [JsonProperty("averageRankedAccuracy")]
            public double AverageRankedAccuracy { get; set; }

            [JsonProperty("averageWeightedRankedAccuracy")]
            public double AverageWeightedRankedAccuracy { get; set; }

            [JsonProperty("averageUnrankedAccuracy")]
            public double AverageUnrankedAccuracy { get; set; }

            [JsonProperty("averageAccuracy")]
            public double AverageAccuracy { get; set; }

            [JsonProperty("medianRankedAccuracy")]
            public double MedianRankedAccuracy { get; set; }

            [JsonProperty("medianAccuracy")]
            public double MedianAccuracy { get; set; }

            [JsonProperty("topRankedAccuracy")]
            public double TopRankedAccuracy { get; set; }

            [JsonProperty("topUnrankedAccuracy")]
            public double TopUnrankedAccuracy { get; set; }

            [JsonProperty("topAccuracy")]
            public double TopAccuracy { get; set; }

            [JsonProperty("topPp")]
            public double TopPp { get; set; }

            [JsonProperty("topBonusPP")]
            public double TopBonusPp { get; set; }

            [JsonProperty("peakRank")]
            public long PeakRank { get; set; }

            [JsonProperty("rankedPlayCount")]
            public long RankedPlayCount { get; set; }

            [JsonProperty("unrankedPlayCount")]
            public long UnrankedPlayCount { get; set; }

            [JsonProperty("totalPlayCount")]
            public long TotalPlayCount { get; set; }

            [JsonProperty("averageRankedRank")]
            public double AverageRankedRank { get; set; }

            [JsonProperty("averageWeightedRankedRank")]
            public long AverageWeightedRankedRank { get; set; }

            [JsonProperty("averageUnrankedRank")]
            public double AverageUnrankedRank { get; set; }

            [JsonProperty("averageRank")]
            public double AverageRank { get; set; }

            [JsonProperty("sspPlays")]
            public long SspPlays { get; set; }

            [JsonProperty("ssPlays")]
            public long SsPlays { get; set; }

            [JsonProperty("spPlays")]
            public long SpPlays { get; set; }

            [JsonProperty("sPlays")]
            public long SPlays { get; set; }

            [JsonProperty("aPlays")]
            public long APlays { get; set; }

            [JsonProperty("topHMD")]
            public long TopHmd { get; set; }

            [JsonProperty("dailyImprovements")]
            public long DailyImprovements { get; set; }

            [JsonProperty("replaysWatched")]
            public long ReplaysWatched { get; set; }

            [JsonProperty("watchedReplays")]
            public long WatchedReplays { get; set; }
        }            
    }
}
