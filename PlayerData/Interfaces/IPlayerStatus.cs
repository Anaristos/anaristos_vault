using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerData.Interfaces
{
    public interface IPlayerStatus
    {
        Int64 Hp    { get; set; }
        Int64 Mana  { get; set; }
        Int64 Moves { get; set; }

        Int64 MaxHp    { get; set; }
        Int64 MaxMana  { get; set; }
        Int64 MaxMoves { get; set; }

        Int64 Dr { get; set; }
        Int64 Hr { get; set; }
    }
}
