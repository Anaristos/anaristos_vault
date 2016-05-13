using System.Collections.Generic;

namespace PlayerData.Interfaces
{
    public interface IPlayerStatusProcessor
    {
        void update(Dictionary<string, object> data);
    }
}
