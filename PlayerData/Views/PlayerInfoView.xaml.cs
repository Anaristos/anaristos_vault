using System.Windows.Controls;
using PlayerData.Unity;

namespace PlayerData.Views
{
    /// <summary>
    /// Interaction logic for PlayerInfoView.xaml
    /// </summary>
    public partial class PlayerInfoView : UserControl
    {
        public PlayerInfoView()
        {
            InitializeComponent();

            DataContext = PlayerInfoInjectionManager.playerInfoViewModel;
        }
    }
}
