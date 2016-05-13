using System;
using PlayerData.Classes;
using PlayerData.Interfaces;

namespace PlayerData.ViewModels
{
    public class PlayerStatsViewModel : IPlayerStatsViewModel
    {
        private IPlayerStats playerStats;

        public PlayerStatsViewModel(IPlayerStats stats)
        {
            playerStats = stats;
        }

        public string Con
        {
            get { return string.Format(CommonData.formats[1], playerStats.Con); }
        }

        public string Dex
        {
            get { return string.Format(CommonData.formats[1], playerStats.Dex); }
        }

        public string Int
        {
            get { return string.Format(CommonData.formats[1], playerStats.Int); }
        }

        public string Luck
        {
            get { return string.Format(CommonData.formats[1], playerStats.Luck); }
        }

        public string Str
        {
            get { return string.Format(CommonData.formats[1], playerStats.Str); }
        }

        public string Wis
        {
            get { return string.Format(CommonData.formats[1], playerStats.Wis); }
        }

        public string MaxCon
        {
            get { return string.Format(CommonData.formats[1], playerStats.MaxCon); }
        }

        public string MaxDex
        {
            get { return string.Format(CommonData.formats[1], playerStats.MaxDex); }
        }

        public string MaxInt
        {
            get { return string.Format(CommonData.formats[1], playerStats.MaxInt); }
        }

        public string MaxLuck
        {
            get { return string.Format(CommonData.formats[1], playerStats.MaxLuck); }
        }

        public string MaxStr
        {
            get { return string.Format(CommonData.formats[1], playerStats.MaxStr); }
        }

        public string MaxWis
        {
            get { return string.Format(CommonData.formats[1], playerStats.MaxWis); }
        }
    }
}
