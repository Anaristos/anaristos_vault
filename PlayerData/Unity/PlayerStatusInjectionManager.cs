using Microsoft.Practices.Unity;
using PlayerData.Injectors;
using PlayerData.Interfaces;
using PlayerData.Models;
using PlayerData.ViewModels;

namespace PlayerData.Unity
{
    public class PlayerStatusInjectionManager
    {
        public static UnityContainer statusContainer { get; private set; }

        public static IPlayerStatus playerStatus { get; private set; }

        public static IPlayerStatusProcessor playerStatusProcessor { get; private set; }

        public static IPlayerStatusViewModel playerStatusViewModel { get; private set; }

        public static void build()
        {
            statusContainer = new UnityContainer();

            statusContainer.RegisterType<IPlayerStatusViewModel, PlayerStatusViewModel>(new ContainerControlledLifetimeManager());

            statusContainer.RegisterType<IPlayerStatus, PlayerStatus>(new ContainerControlledLifetimeManager());

            statusContainer.RegisterType<IPlayerStatusProcessor, PlayerStatusProcessor>(new ContainerControlledLifetimeManager());

            playerStatus = statusContainer.Resolve<PlayerStatus>();

            playerStatusProcessor = statusContainer.Resolve<PlayerStatusProcessor>();

            playerStatusViewModel = statusContainer.Resolve<PlayerStatusViewModel>();
        }
    }
}