using Microsoft.Practices.Unity;
using PlayerData.Injectors;
using PlayerData.Interfaces;
using PlayerData.Models;
using PlayerData.ViewModels;

namespace PlayerData.Unity
{
    public class PlayerStatsInjectionManager
    {
        public static UnityContainer        statsContainer       { get; private set; }

        public static IPlayerStats          playerStats          { get; private set; }

        public static IPlayerStatsProcessor playerStatsProcessor { get; private set; }

        public static IPlayerStatsViewModel playerStatsViewModel { get; private set; }

        public static void build()
        {
            statsContainer = new UnityContainer();

            statsContainer.RegisterType<IPlayerStatsViewModel, PlayerStatsViewModel>(new ContainerControlledLifetimeManager());

            statsContainer.RegisterType<IPlayerStats, PlayerStats>(new ContainerControlledLifetimeManager());

            statsContainer.RegisterType<IPlayerStatsProcessor, PlayerStatsProcessor>(new ContainerControlledLifetimeManager());

            playerStats = statsContainer.Resolve<PlayerStats>();

            playerStatsProcessor = statsContainer.Resolve<PlayerStatsProcessor>();

            playerStatsViewModel = statsContainer.Resolve<PlayerStatsViewModel>();
        }
    }
}
