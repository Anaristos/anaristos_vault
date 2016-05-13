using System.Collections.Generic;
using PlayerData.Interfaces;
using System;

namespace PlayerData.Injectors
{
    public class PlayerInfoProcessor : IPlayerInfoProcessor
    {
        private IPlayerInfo playerInfo;

        private object item;

        public PlayerInfoProcessor(IPlayerInfo info)
        {
            playerInfo = info;
        }

        public void update(Dictionary<string, object> data)
        {
            if (data.TryGetValue("name",  out item)) playerInfo.Name  = (string) item;

            if (data.TryGetValue("align", out item)) playerInfo.Align = (long)   item;

            if (data.TryGetValue("level", out item)) playerInfo.Level = (long)   item;

            if (data.TryGetValue("state", out item)) playerInfo.State = (long)   item;

            if (data.TryGetValue("tnl",   out item)) playerInfo.TNL   = (long)   item;
        }
    }
}
