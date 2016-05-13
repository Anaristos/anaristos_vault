using System;
using PlayerData.Classes;
using PlayerData.Interfaces;

namespace PlayerData.Models
{
    class PlayerStats : NotifyPropertyChanges, IPlayerStats
    {
        private Int64 con;

        private Int64 dex;

        private Int64 intr;

        private Int64 luck;

        private Int64 str;

        private Int64 wis;

        private Int64 maxcon;

        private Int64 maxdex;

        private Int64 maxintr;

        private Int64 maxluck;

        private Int64 maxstr;

        private Int64 maxwis;


        public Int64 Con
        {
            get { return con; }

            set
            {
                if ( con != value)
                {
                    con = value;

                    OnPropertyChanged("Con");
                }
            }            
        }

        public Int64 Dex
        {
            get { return dex; }

            set
            {
                if (dex != value)
                {
                    dex = value;

                    OnPropertyChanged("Dex");
                }
            }
        }

        public Int64 Int
        {
            get { return intr; }

            set
            {
                if (intr != value)
                {
                    intr = value;

                    OnPropertyChanged("Int");
                }
            }
        }

        public Int64 Luck
        {
            get { return luck; }

            set
            {
                if (luck != value)
                {
                    luck = value;

                    OnPropertyChanged("Luck");
                }
            }
        }

        public Int64 Str
        {
            get { return str; }

            set
            {
                if (str != value)
                {
                    str = value;

                    OnPropertyChanged("Str");
                }
            }
        }

        public Int64 Wis
        {
            get { return wis; }

            set
            {
                if (wis != value)
                {
                    wis = value;

                    OnPropertyChanged("Wis");
                }
            }
        }

        public Int64 MaxCon
        {
            get { return maxcon; }

            set
            {
                if (maxcon != value)
                {
                    maxcon = value;

                    OnPropertyChanged("MaxCon");
                }
            }

        }

        public Int64 MaxDex
        {
            get { return maxdex; }

            set
            {
                if (maxdex != value)
                {
                    maxdex = value;

                    OnPropertyChanged("MaxDex");
                }
            }

        }

        public Int64 MaxInt
        {
            get { return maxintr; }

            set
            {
                if (maxintr != value)
                {
                    maxintr = value;

                    OnPropertyChanged("MaxInt");
                }
            }

        }

        public Int64 MaxLuck
        {
            get { return maxluck; }

            set
            {
                if (maxluck != value)
                {
                    maxluck = value;

                    OnPropertyChanged("MaxLuck");
                }
            }

        }

        public Int64 MaxStr
        {
            get { return maxstr; }

            set
            {
                if (maxstr != value)
                {
                    maxstr = value;

                    OnPropertyChanged("MaxStr");
                }
            }

        }

        public Int64 MaxWis
        {
            get { return maxwis; }

            set
            {
                if (maxwis != value)
                {
                   maxwis = value;

                    OnPropertyChanged("MaxWis");
                }
            }

        }
    }
}
