using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLib.Models
{
    public class PlayerModel
    {
        public partial class Player
        {
            [JsonProperty("mapperId")]
            public long MapperId { get; set; }

            [JsonProperty("banned")]
            public bool Banned { get; set; }

            [JsonProperty("inactive")]
            public bool Inactive { get; set; }

            [JsonProperty("externalProfileUrl")]
            public Uri ExternalProfileUrl { get; set; }

            [JsonProperty("history")]
            public object History { get; set; }

            [JsonProperty("badges")]
            public List<Badge> Badges { get; set; }

            [JsonProperty("pinnedScores")]
            public object PinnedScores { get; set; }

            [JsonProperty("changes")]
            public List<object> Changes { get; set; }

            [JsonProperty("histories")]
            public string Histories { get; set; }

            [JsonProperty("scoreStats")]
            public ScoreStats ScoreStats { get; set; }

            [JsonProperty("lastWeekPp")]
            public double LastWeekPp { get; set; }

            [JsonProperty("lastWeekRank")]
            public long LastWeekRank { get; set; }

            [JsonProperty("lastWeekCountryRank")]
            public long LastWeekCountryRank { get; set; }

            [JsonProperty("eventsParticipating")]
            public List<EventsParticipating> EventsParticipating { get; set; }

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
            public List<object> Socials { get; set; }

            [JsonProperty("patreonFeatures")]
            public object PatreonFeatures { get; set; }

            [JsonProperty("profileSettings")]
            public object ProfileSettings { get; set; }

            [JsonProperty("clans")]
            public List<object> Clans { get; set; }
        }

        public partial class Badge
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("image")]
            public Uri Image { get; set; }

            [JsonProperty("link")]
            public Uri Link { get; set; }
        }

        public partial class EventsParticipating
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("eventId")]
            public long EventId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("playerId")]
            public string PlayerId { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("rank")]
            public long Rank { get; set; }

            [JsonProperty("countryRank")]
            public long CountryRank { get; set; }

            [JsonProperty("pp")]
            public double Pp { get; set; }
        }

        public partial class ScoreStats
        {
            [JsonProperty("id")]
            public long Id { get; set; }

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
            public long TopUnrankedAccuracy { get; set; }

            [JsonProperty("topAccuracy")]
            public long TopAccuracy { get; set; }

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
            public double AverageWeightedRankedRank { get; set; }

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

            [JsonProperty("topPlatform")]
            public string TopPlatform { get; set; }

            [JsonProperty("topHMD")]
            public long TopHmd { get; set; }

            [JsonProperty("dailyImprovements")]
            public long DailyImprovements { get; set; }

            [JsonProperty("authorizedReplayWatched")]
            public long AuthorizedReplayWatched { get; set; }

            [JsonProperty("anonimusReplayWatched")]
            public long AnonimusReplayWatched { get; set; }

            [JsonProperty("watchedReplays")]
            public long WatchedReplays { get; set; }
        }
    }
}
