using System.Windows.Controls;
using PlayerData.Unity;

namespace PlayerData.Views
{
    /// <summary>
    /// Interaction logic for PlayerStatsView.xaml
    /// </summary>
    public partial class PlayerStatsView : UserControl
    {
        public PlayerStatsView()
        {
            InitializeComponent();

            DataContext = PlayerStatsInjectionManager.playerStatsViewModel;
        }
    }
}
