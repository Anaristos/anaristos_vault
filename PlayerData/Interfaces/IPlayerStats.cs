using System;

namespace PlayerData.Interfaces
{
    public interface IPlayerStats
    {
        Int64 Con  { get; set; }

        Int64 Dex  { get; set; }

        Int64 Int  { get; set; }

        Int64 Luck { get; set; }

        Int64 Str  { get; set; }

        Int64 Wis  { get; set; }


        Int64 MaxCon  { get; set; }

        Int64 MaxDex  { get; set; }

        Int64 MaxInt  { get; set; }

        Int64 MaxLuck { get; set; }

        Int64 MaxStr  { get; set; }

        Int64 MaxWis  { get; set; }
    }
}
