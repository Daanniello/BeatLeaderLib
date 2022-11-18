using BeatLeaderLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatLeaderLib.Endpoints
{
    public class Clan : EndpointBase
    {
        public Clan()
        {

        }

        public Task<ClanModel.Clan> GetClan(int page = 1, int count = 10, string sort = "pp", string order = "desc", string? searchUsername = null, string type = null)
        {                      
            return Get<ClanModel.Clan>($"/clans?page={page}&count={count}&sort={sort}&order={order}{(searchUsername != null ? searchUsername : "")}{(type != null ? type : "")}"); ;
        }

        //public Task<ClanModel.Clan> GetClanByTag(string tag, int page = 1, int count = 10, string sort = "pp", string order = "desc", string? searchUsername = null, string type = null)
        //{

        //}
    }
}
