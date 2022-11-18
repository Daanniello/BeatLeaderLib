using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLib.Models
{
    public class LeaderboardModel
    {
        public partial class Leaderboard
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("song")]
            public Song Song { get; set; }

            [JsonProperty("difficulty")]
            public Difficulty Difficulty { get; set; }

            [JsonProperty("scores")]
            public List<Score> Scores { get; set; }

            [JsonProperty("changes")]
            public List<Change> Changes { get; set; }

            [JsonProperty("qualification")]
            public Qualification Qualification { get; set; }

            [JsonProperty("reweight")]
            public object Reweight { get; set; }

            [JsonProperty("plays")]
            public long Plays { get; set; }
        }

        public partial class Change
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("timeset")]
            public long Timeset { get; set; }

            [JsonProperty("playerId")]
            public string PlayerId { get; set; }

            [JsonProperty("oldRankability")]
            public long OldRankability { get; set; }

            [JsonProperty("oldStars")]
            public double OldStars { get; set; }

            [JsonProperty("oldType")]
            public long OldType { get; set; }

            [JsonProperty("oldCriteriaMet")]
            public long OldCriteriaMet { get; set; }

            [JsonProperty("oldModifiers")]
            public ModifierValues OldModifiers { get; set; }

            [JsonProperty("newRankability")]
            public long NewRankability { get; set; }

            [JsonProperty("newStars")]
            public double NewStars { get; set; }

            [JsonProperty("newType")]
            public long NewType { get; set; }

            [JsonProperty("newCriteriaMet")]
            public long NewCriteriaMet { get; set; }

            [JsonProperty("newModifiers")]
            public ModifierValues NewModifiers { get; set; }

            [JsonProperty("oldCriteriaCommentary")]
            public object OldCriteriaCommentary { get; set; }

            [JsonProperty("newCriteriaCommentary")]
            public object NewCriteriaCommentary { get; set; }
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
            public double Stars { get; set; }

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

        public partial class Qualification
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("timeset")]
            public long Timeset { get; set; }

            [JsonProperty("rtMember")]
            public string RtMember { get; set; }

            [JsonProperty("criteriaTimeset")]
            public long CriteriaTimeset { get; set; }

            [JsonProperty("criteriaMet")]
            public long CriteriaMet { get; set; }

            [JsonProperty("criteriaChecker")]
            public string CriteriaChecker { get; set; }

            [JsonProperty("criteriaCommentary")]
            public object CriteriaCommentary { get; set; }

            [JsonProperty("mapperAllowed")]
            public bool MapperAllowed { get; set; }

            [JsonProperty("mapperId")]
            public string MapperId { get; set; }

            [JsonProperty("mapperQualification")]
            public bool MapperQualification { get; set; }

            [JsonProperty("approvalTimeset")]
            public long ApprovalTimeset { get; set; }

            [JsonProperty("approved")]
            public bool Approved { get; set; }

            [JsonProperty("approvers")]
            public string Approvers { get; set; }

            [JsonProperty("modifiers")]
            public ModifierValues Modifiers { get; set; }

            [JsonProperty("changes")]
            public List<Change> Changes { get; set; }
        }

        public partial class Score
        {
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

            [JsonProperty("timepost")]
            public long Timepost { get; set; }

            [JsonProperty("replaysWatched")]
            public long ReplaysWatched { get; set; }

            [JsonProperty("player")]
            public Player Player { get; set; }

            [JsonProperty("scoreImprovement")]
            public object ScoreImprovement { get; set; }

            [JsonProperty("rankVoting")]
            public object RankVoting { get; set; }

            [JsonProperty("metadata")]
            public object Metadata { get; set; }
        }

        public partial class Player
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

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

            [JsonProperty("socials")]
            public object Socials { get; set; }

            [JsonProperty("patreonFeatures")]
            public object PatreonFeatures { get; set; }

            [JsonProperty("profileSettings")]
            public ProfileSettings ProfileSettings { get; set; }

            [JsonProperty("clans")]
            public List<Clan> Clans { get; set; }
        }

        public partial class Clan
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("tag")]
            public string Tag { get; set; }

            [JsonProperty("color")]
            public string Color { get; set; }
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
            public string EffectName { get; set; }

            [JsonProperty("profileAppearance")]
            public string ProfileAppearance { get; set; }

            [JsonProperty("hue")]
            public long Hue { get; set; }

            [JsonProperty("saturation")]
            public long Saturation { get; set; }

            [JsonProperty("leftSaberColor")]
            public object LeftSaberColor { get; set; }

            [JsonProperty("rightSaberColor")]
            public object RightSaberColor { get; set; }
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
            public object Tags { get; set; }

            [JsonProperty("createdTime")]
            public string CreatedTime { get; set; }

            [JsonProperty("uploadTime")]
            public long UploadTime { get; set; }

            [JsonProperty("difficulties")]
            public List<Difficulty> Difficulties { get; set; }
        }
    }
}
