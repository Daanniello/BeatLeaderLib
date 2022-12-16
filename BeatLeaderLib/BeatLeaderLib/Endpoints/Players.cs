using BeatLeaderLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLib.Endpoints
{
    public class Players : EndpointBase
    {
        public Players()
        {

        }

        public Task<PlayerModel.Player> GetPlayerByID(string id)
        {
            return Get<PlayerModel.Player>($"player/{id}?stats=true");
        }

        public Task<PlayersModel> GetPlayers(string search = null, string country = null, string mapType = null, string ppRange = null, string scoreRange = null, string platform = null, string hmd = null, string clans = null, string activityPeriod = null, string sortBy = "pp", int page = 1, int count = 50, string orderBy = "desc")
        {
            return Get<PlayersModel>($"players?sortBy={sortBy}&page={page}&count={count}" +
                $"{(search != null ? $"&search={search}" : "")}" +
                $"&order={orderBy}" +
                $"{(country != null ? $"&countries={country}" : "")}" +
                $"{(mapType != null ? $"&mapsType={mapType}" : "")}" +
                $"{(ppRange != null ? $"&pp_range={ppRange}" : "")}" +
                $"{(scoreRange != null ? $"&score_range={scoreRange}" : "")}" +
                $"{(platform != null ? $"&platform={platform}" : "")}" +
                $"{(hmd != null ? $"&hmd={hmd}" : "")}" +
                $"{(clans != null ? $"&clans={clans}" : "")}" +
                $"{(activityPeriod != null ? $"&activityPeriod={activityPeriod}" : "")}");
        }

        public Task<PlayerScoresModel.PlayerScores> GetPlayerScoresByID(string id, string sortBy = "date", string order = "desc", int page = 1, int count = 8, string search = null, string diff = null, int? stars_from = null, int? stars_to = null, int? time_from = null, int? time_to = null)
        {
            return Get<PlayerScoresModel.PlayerScores>($"player/{id}/scores?sortBy={sortBy}&order={order}&page={page}&count={count}" +
                $"{(search != null ? $"&search={search}" : "")}" +
                $"{(diff != null ? $"&diff={diff}" : "")}" +
                $"{(stars_from != null ? $"&stars_from={stars_from}" : "")}" +
                $"{(stars_to != null ? $"&stars_to={stars_to}" : "")}" +
                $"{(time_from != null ? $"&time_from={time_from}" : "")}" +
                $"{(time_to != null ? $"&time_to={time_to}" : "")}");
        }

        public Task<List<PlayerHistoryModel.PlayerHistory>> GetPlayerHistoryByID(string id, int count = 50)
        {
            return Get<List<PlayerHistoryModel.PlayerHistory>>($"player/{id}/history?count={count}");
        }
    }
}
