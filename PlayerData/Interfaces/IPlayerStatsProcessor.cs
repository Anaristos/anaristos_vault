using System.Collections.Generic;

namespace PlayerData.Interfaces
{
    public interface IPlayerStatsProcessor
    {
        void update(Dictionary<string, object> data);
    }
}
