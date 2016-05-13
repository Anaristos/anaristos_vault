using System;
using PlayerData.Classes;
using PlayerData.Interfaces;

namespace PlayerData.Models
{
    public class PlayerInfo : NotifyPropertyChanges, IPlayerInfo
    {
        private string name;

        private Int64 align;

        private Int64 level;

        private Int64 state;

        private Int64 tnl;

        public string Name
        {
            get { return name; }

            set
            {
                if (name != value)
                {
                    name = value;

                    OnPropertyChanged("Name");
                }
            }
        }

        public Int64 Align
        {
            get { return align; }

            set
            {
                if (align != value)
                {
                    align = value;

                    OnPropertyChanged("Align");
                }
            }
        }

        public Int64 Level
        {
            get { return level; }

            set
            {
                if (level != value)
                {
                    level = value;

                    OnPropertyChanged("Level");
                }
            }
        }


        public Int64 State
        {
            get { return state; }

            set
            {
                if (state != value)
                {
                    state = value;

                    OnPropertyChanged("State");
                }
            }
        }

        public Int64 TNL
        {
            get { return tnl; }

            set
            {
                if (tnl != value)
                {
                    tnl = value;

                    OnPropertyChanged("TNL");
                }
            }
        }        
    }
}
