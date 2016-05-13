using PlayerData.Unity;
using System.Windows.Controls;

namespace PlayerData.Views
{
    /// <summary>
    /// Interaction logic for PlayerStatusView.xaml
    /// </summary>
    public partial class PlayerStatusView : UserControl
    {
        public PlayerStatusView()
        {
            InitializeComponent();

            DataContext = PlayerStatusInjectionManager.playerStatusViewModel;
        }
    }
}
