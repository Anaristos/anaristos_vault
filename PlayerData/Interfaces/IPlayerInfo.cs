using System;

namespace PlayerData.Interfaces
{
    public interface IPlayerInfo
    {
        string Name { get; set; }

        Int64 Align { get; set; }

        Int64 Level { get; set; }

        Int64 State { get; set; }

        Int64 TNL   { get; set; }
    }
}
