using System.Collections.Generic;

namespace PlayerData.Interfaces
{
    public interface IPlayerInfoProcessor
    {
        void update(Dictionary<string, object> data);
    }
}
