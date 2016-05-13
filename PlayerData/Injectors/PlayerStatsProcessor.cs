using System.Collections.Generic;
using PlayerData.Interfaces;

namespace PlayerData.Injectors
{
    public class PlayerStatsProcessor : IPlayerStatsProcessor
    {
        private IPlayerStats playerStats;

        private object item;

        public PlayerStatsProcessor(IPlayerStats stats)
        {
            playerStats = stats;
        }

        public void update(Dictionary<string, object> data)
        {
            if (data.TryGetValue("con",  out item)) playerStats.Con  = (long) item;

            if (data.TryGetValue("dex",  out item)) playerStats.Dex  = (long) item;

            if (data.TryGetValue("intr", out item)) playerStats.Int  = (long) item;

            if (data.TryGetValue("luck", out item)) playerStats.Luck = (long) item;

            if (data.TryGetValue("str",  out item)) playerStats.Str  = (long) item;

            if (data.TryGetValue("wis",  out item)) playerStats.Wis  = (long) item;


            if (data.TryGetValue("maxcon",  out item)) playerStats.MaxCon  = (long) item;

            if (data.TryGetValue("maxdex",  out item)) playerStats.MaxDex  = (long) item;

            if (data.TryGetValue("maxint",  out item)) playerStats.MaxInt  = (long) item;

            if (data.TryGetValue("maxluck", out item)) playerStats.MaxLuck = (long) item;

            if (data.TryGetValue("maxstr",  out item)) playerStats.MaxStr  = (long) item;

            if (data.TryGetValue("maxwis",  out item)) playerStats.MaxWis  = (long) item;
        }
    }
}
