using PlayerData;
using PlayerData.Unity;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace PlayerDisplay
{
    public class Agent
    {
        private MainWindow win;

        private delegate void exec(Dictionary<string, object> data);

        private List<exec> xlist;

        private List<Action> actions = new List<Action>() { { () => PlayerInfoInjectionManager.build()   }
                                                           ,{ () => PlayerStatsInjectionManager.build()  }
                                                           ,{ () => PlayerStatusInjectionManager.build() }};

        public Agent()
        {
            Thread t = new Thread(new ThreadStart(this.Program));

            foreach (var action in actions) action();

            t.SetApartmentState(ApartmentState.STA);

            t.Start();

            xlist = new List<exec>() { new exec(PlayerInfoInjectionManager.playerInfoProcessor.update)
                                      ,new exec(PlayerStatsInjectionManager.playerStatsProcessor.update)
                                      ,new exec(PlayerStatusInjectionManager.playerStatusProcessor.update) };
        }

        public void update(string gmcpData)
        {
            Dictionary<string, object> data = (Dictionary<string, object>) NEWJSON.NEWJSON.JsonDecode(gmcpData);

            foreach (var func in xlist) func(data);
        }

        private void Program()
        {
            Application app = new Application();

            win = new MainWindow();

            app.MainWindow = win;

            app.MainWindow.Show();

            app.Run();
        }
    }
}
