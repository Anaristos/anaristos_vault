using PlayerData.Interfaces;
using PlayerData.Classes;
using System;

namespace PlayerData.ViewModels
{
    public class PlayerInfoViewModel : IPlayerInfoViewModel
    {
        private IPlayerInfo playerInfo;

        public PlayerInfoViewModel(IPlayerInfo info)
        {
            playerInfo = info;
        }

        public string Name
        {
            get { return playerInfo.Name; }
        }

        public string Align
        {
            get { return string.Format(CommonData.formats[2], Math.Abs(playerInfo.Align)); }
        }

        public string AlignColor
        {
            get
            {
                if (playerInfo.Align > 875) return "SpringGreen";

                else if (playerInfo.Align < 875) return "Red";

                return "Yellow";
            }
        }

        public string Level
        {
            get { return string.Format(CommonData.formats[1], playerInfo.Level); }
        }

        public string State
        {
            get { return CommonData.states[playerInfo.State - 1]; }
        }

        public string StateColor
        {
            get { return CommonData.scolors[playerInfo.State - 1]; }
        }

        public string TNL
        {
            get { return string.Format(CommonData.formats[3], playerInfo.TNL); }
        }
    }
}
