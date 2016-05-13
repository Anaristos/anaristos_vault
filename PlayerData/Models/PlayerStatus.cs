using PlayerData.Classes;
using PlayerData.Interfaces;

namespace PlayerData.Models
{
    public class PlayerStatus : NotifyPropertyChanges, IPlayerStatus
    {
        private long hp;
        private long mana;
        private long moves;
        private long maxhp;
        private long maxmana;
        private long maxmoves;
        private long hr;
        private long dr;

        public long Hp
        {
            get { return hp; }

            set
            {
                if (hp != value)
                {
                    hp = value;

                    OnPropertyChanged("Hp");
                }
            }
        }

        public long Mana
        {
            get { return mana; }

            set
            {
                if (mana != value)
                {
                    mana = value;

                    OnPropertyChanged("Mana");
                }
            }
        }

        public long Moves
        {
            get { return moves; }

            set
            {
                if (moves != value)
                {
                    moves = value;

                    OnPropertyChanged("Moves");
                }
            }
        }


        public long MaxHp
        {
            get { return maxhp; }

            set
            {
                if (maxhp != value)
                {
                    maxhp = value;

                    OnPropertyChanged("MaxHp");
                }
            }
        }

        public long MaxMana
        {
            get { return maxmana; }

            set
            {
                if (maxmana != value)
                {
                    maxmana = value;

                    OnPropertyChanged("MaxMana");
                }
            }
        }

        public long MaxMoves
        {
            get { return maxmoves; }

            set
            {
                if (maxmoves != value)
                {
                    maxmoves = value;

                    OnPropertyChanged("MaxMoves");
                }
            }
        }

        public long Dr
        {
            get { return dr; }

            set
            {
                if (dr != value)
                {
                    dr = value;

                    OnPropertyChanged("Dr");
                }
            }
        }

        public long Hr
        {
            get { return hr; }

            set
            {
                if (hr != value)
                {
                    hr = value;

                    OnPropertyChanged("Hr");
                }
            }
        }
    }
}
