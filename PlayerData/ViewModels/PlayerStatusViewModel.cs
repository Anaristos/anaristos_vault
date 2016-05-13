using PlayerData.Classes;
using PlayerData.Interfaces;

namespace PlayerData.ViewModels
{
    public class PlayerStatusViewModel : IPlayerStatusViewModel
    {
        private IPlayerStatus playerStatus;

        private string getColor(long _value)
        {
            if (_value > 100) return "DodgerBlue";
            else if (_value > 75) return "SpringGreen";
            else if (_value > 50) return "Yellow";
            else if (_value > 25) return "Orchid";
            else return "Red";
        }

        public PlayerStatusViewModel(IPlayerStatus status)
        {
            playerStatus = status;
        }

        public string Hp    { get { return string.Format(CommonData.formats[3], playerStatus.Hp);    } }
        public string Mana  { get { return string.Format(CommonData.formats[3], playerStatus.Mana);  } }
        public string Moves { get { return string.Format(CommonData.formats[3], playerStatus.Moves); } }

        public string MaxHp    { get { return string.Format(CommonData.formats[3], playerStatus.MaxHp);    } }
        public string MaxMana  { get { return string.Format(CommonData.formats[3], playerStatus.MaxMana);  } }
        public string MaxMoves { get { return string.Format(CommonData.formats[3], playerStatus.MaxMoves); } }

        public string HpColor    { get { return getColor(100 * playerStatus.Hp    / playerStatus.MaxHp);    } }
        public string ManaColor  { get { return getColor(100 * playerStatus.Mana  / playerStatus.MaxMana);  } }
        public string MovesColor { get { return getColor(100 * playerStatus.Moves / playerStatus.MaxMoves); } }

        public string Dr { get { return string.Format(CommonData.formats[3], playerStatus.Dr); } }
        public string Hr { get { return string.Format(CommonData.formats[3], playerStatus.Hr); } }
    }
}
