using Microsoft.Practices.Unity;
using PlayerData.Injectors;
using PlayerData.Interfaces;
using PlayerData.Models;
using PlayerData.ViewModels;

namespace PlayerData.Unity
{
    public static class PlayerInfoInjectionManager
    {
        public static UnityContainer       infoContainer       { get; private set; }

        public static IPlayerInfo          playerInfo          { get; private set; }

        public static IPlayerInfoProcessor playerInfoProcessor { get; private set; }

        public static IPlayerInfoViewModel playerInfoViewModel { get; private set; }

        public static void build()
        {
            infoContainer = new UnityContainer();

            infoContainer.RegisterType<IPlayerInfoViewModel, PlayerInfoViewModel>(new ContainerControlledLifetimeManager());

            infoContainer.RegisterType<IPlayerInfo, PlayerInfo>(new ContainerControlledLifetimeManager());

            infoContainer.RegisterType<IPlayerInfoProcessor, PlayerInfoProcessor>(new ContainerControlledLifetimeManager());

            playerInfo = infoContainer.Resolve<PlayerInfo>();

            playerInfoProcessor = infoContainer.Resolve<PlayerInfoProcessor>();

            playerInfoViewModel = infoContainer.Resolve<PlayerInfoViewModel>();
        }
    }
}
