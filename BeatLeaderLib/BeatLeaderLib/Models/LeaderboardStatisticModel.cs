using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLib.Models
{
    public class LeaderboardStatisticModel
    {
        public partial class LeaderboardStatistic
        {
            [JsonProperty("hitTracker")]
            public HitTracker HitTracker { get; set; }

            [JsonProperty("accuracyTracker")]
            public AccuracyTracker AccuracyTracker { get; set; }

            [JsonProperty("winTracker")]
            public WinTracker WinTracker { get; set; }

            [JsonProperty("scoreGraphTracker")]
            public ScoreGraphTracker ScoreGraphTracker { get; set; }
        }

        public partial class AccuracyTracker
        {
            [JsonProperty("accRight")]
            public double AccRight { get; set; }

            [JsonProperty("accLeft")]
            public double AccLeft { get; set; }

            [JsonProperty("leftPreswing")]
            public double LeftPreswing { get; set; }

            [JsonProperty("rightPreswing")]
            public double RightPreswing { get; set; }

            [JsonProperty("averagePreswing")]
            public long AveragePreswing { get; set; }

            [JsonProperty("leftPostswing")]
            public double LeftPostswing { get; set; }

            [JsonProperty("rightPostswing")]
            public double RightPostswing { get; set; }

            [JsonProperty("leftTimeDependence")]
            public double LeftTimeDependence { get; set; }

            [JsonProperty("rightTimeDependence")]
            public double RightTimeDependence { get; set; }

            [JsonProperty("leftAverageCut")]
            public List<double> LeftAverageCut { get; set; }

            [JsonProperty("rightAverageCut")]
            public List<double> RightAverageCut { get; set; }

            [JsonProperty("gridAcc")]
            public List<double> GridAcc { get; set; }
        }

        public partial class HitTracker
        {
            [JsonProperty("maxCombo")]
            public long MaxCombo { get; set; }

            [JsonProperty("leftMiss")]
            public long LeftMiss { get; set; }

            [JsonProperty("rightMiss")]
            public long RightMiss { get; set; }

            [JsonProperty("leftBadCuts")]
            public long LeftBadCuts { get; set; }

            [JsonProperty("rightBadCuts")]
            public long RightBadCuts { get; set; }

            [JsonProperty("leftBombs")]
            public long LeftBombs { get; set; }

            [JsonProperty("rightBombs")]
            public long RightBombs { get; set; }
        }

        public partial class ScoreGraphTracker
        {
            [JsonProperty("graph")]
            public List<double> Graph { get; set; }
        }

        public partial class WinTracker
        {
            [JsonProperty("won")]
            public bool Won { get; set; }

            [JsonProperty("endTime")]
            public double EndTime { get; set; }

            [JsonProperty("nbOfPause")]
            public long NbOfPause { get; set; }

            [JsonProperty("jumpDistance")]
            public double JumpDistance { get; set; }

            [JsonProperty("averageHeight")]
            public double AverageHeight { get; set; }

            [JsonProperty("averageHeadPosition")]
            public object AverageHeadPosition { get; set; }

            [JsonProperty("totalScore")]
            public long TotalScore { get; set; }
        }
    }
}
