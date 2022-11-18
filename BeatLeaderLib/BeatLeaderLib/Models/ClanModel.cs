using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLib.Models
{
    public class ClanModel
    {
        public class Clan
        {
            [JsonProperty("metadata")]
            public Metadata Metadata { get; set; }

            [JsonProperty("data")]
            public List<Data> Data { get; set; }
        }

        public class Data
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("color")]
            public string Color { get; set; }

            [JsonProperty("icon")]
            public Uri Icon { get; set; }

            [JsonProperty("tag")]
            public string Tag { get; set; }

            [JsonProperty("leaderID")]
            public string LeaderId { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("bio")]
            public string Bio { get; set; }

            [JsonProperty("playersCount")]
            public long PlayersCount { get; set; }

            [JsonProperty("pp")]
            public double Pp { get; set; }

            [JsonProperty("averageRank")]
            public double AverageRank { get; set; }

            [JsonProperty("averageAccuracy")]
            public double AverageAccuracy { get; set; }

            [JsonProperty("players")]
            public List<object> Players { get; set; }

            [JsonProperty("requests")]
            public List<object> Requests { get; set; }

            [JsonProperty("banned")]
            public List<object> Banned { get; set; }
        }

        public class Metadata
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
