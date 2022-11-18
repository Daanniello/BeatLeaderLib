using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLib.Models
{
    public class LeaderboardsModel
    {
        public partial class Leaderboards
        {
            [JsonProperty("metadata")]
            public Metadata Metadata { get; set; }

            [JsonProperty("data")]
            public List<Data> Data { get; set; }
        }

        public partial class Data
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("song")]
            public Song Song { get; set; }

            [JsonProperty("difficulty")]
            public Difficulty Difficulty { get; set; }

            [JsonProperty("plays")]
            public long Plays { get; set; }

            [JsonProperty("positiveVotes")]
            public long PositiveVotes { get; set; }

            [JsonProperty("starVotes")]
            public long StarVotes { get; set; }

            [JsonProperty("negativeVotes")]
            public long NegativeVotes { get; set; }

            [JsonProperty("voteStars")]
            public double VoteStars { get; set; }

            [JsonProperty("myScore")]
            public object MyScore { get; set; }

            [JsonProperty("qualification")]
            public object Qualification { get; set; }

            [JsonProperty("reweight")]
            public Reweight Reweight { get; set; }
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
            public Modifier ModifierValues { get; set; }

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
        }

        public partial class Modifier
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

        public partial class Reweight
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("timeset")]
            public long Timeset { get; set; }

            [JsonProperty("rtMember")]
            public string RtMember { get; set; }

            [JsonProperty("keep")]
            public bool Keep { get; set; }

            [JsonProperty("stars")]
            public double Stars { get; set; }

            [JsonProperty("type")]
            public long Type { get; set; }

            [JsonProperty("criteriaMet")]
            public long CriteriaMet { get; set; }

            [JsonProperty("criteriaCommentary")]
            public string CriteriaCommentary { get; set; }

            [JsonProperty("finished")]
            public bool Finished { get; set; }

            [JsonProperty("modifiers")]
            public Modifier Modifiers { get; set; }

            [JsonProperty("changes")]
            public object Changes { get; set; }
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
