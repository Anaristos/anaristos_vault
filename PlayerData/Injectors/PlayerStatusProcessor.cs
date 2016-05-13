using PlayerData.Interfaces;
using System.Collections.Generic;

namespace PlayerData.Injectors
{
    public class PlayerStatusProcessor : IPlayerStatusProcessor
    {
        private IPlayerStatus playerStatus;

        private object item;

        public PlayerStatusProcessor(IPlayerStatus status)
        {
            playerStatus = status;
        }

        public void update(Dictionary<string, object> data)
        {
            if (data.TryGetValue("hp",    out item)) playerStatus.Hp    = (long) item;

            if (data.TryGetValue("mana",  out item)) playerStatus.Mana  = (long) item;

            if (data.TryGetValue("moves", out item)) playerStatus.Moves = (long) item;


            if (data.TryGetValue("maxhp",    out item)) playerStatus.MaxHp    = (long) item;

            if (data.TryGetValue("maxmana",  out item)) playerStatus.MaxMana  = (long) item;

            if (data.TryGetValue("maxmoves", out item)) playerStatus.MaxMoves = (long) item;


            if (data.TryGetValue("dr", out item)) playerStatus.Dr = (long) item;

            if (data.TryGetValue("hr", out item)) playerStatus.Hr = (long) item;
        }
    }
}
