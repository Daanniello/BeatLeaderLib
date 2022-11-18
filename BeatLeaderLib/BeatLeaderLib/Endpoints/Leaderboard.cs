using BeatLeaderLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLib.Endpoints
{
    public class Leaderboard : EndpointBase
    {
        public Leaderboard()
        {

        }

        public Task<LeaderboardModel.Leaderboard> GetLeaderboardByID(string id, int page = 1, int count = 10, string countries = null)
        {
            return Get<LeaderboardModel.Leaderboard>($"leaderboard/{id}?page={page}&count={count}{(countries != null ? $"&countries={countries}" : "")}&friends=false&voters=false");
        }
        public Task<LeaderboardModel.Leaderboard> GetLeaderboardByHash(string hash)
        {
            return Get<LeaderboardModel.Leaderboard>($"leaderboards/hash/{hash}");
        }

        public Task<LeaderboardsModel.Leaderboards> GetLeaderboards(int page = 1, int count = 10, string sortBy = null, string order = null, string search = null, int? stars_from = null, int? stars_to = null, int? date_from = null, int? date_to = null)
        {
            return Get<LeaderboardsModel.Leaderboards>($"leaderboards?page={page}&count={count}" +
                $"{(sortBy != null ? $"&sortBy={sortBy}" : "")}" +
                $"{(order != null ? $"&order={order}" : "")}" +
                $"{(search != null ? $"&search={search}" : "")}" +
                $"{(stars_from != null ? $"&stars_from={stars_from}" : "")}" +
                $"{(stars_to != null ? $"&stars_to={stars_to}" : "")}" +
                $"{(date_from != null ? $"&date_from={date_from}" : "")}" +
                $"{(date_to != null ? $"&date_to={date_to}" : "")}");
        }

        public Task<LeaderboardStatisticModel.LeaderboardStatistic> GetLeaderboardStatistic(string id)
        {
            return Get<LeaderboardStatisticModel.LeaderboardStatistic>($"leaderboard/statistic/{id}");
        }
    }
}
