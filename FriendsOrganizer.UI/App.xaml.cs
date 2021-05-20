using Autofac;
using FriendsOrganizer.UI.Startup;
using System.Windows;

namespace FriendsOrganizer.UI
{
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();
            container.Resolve<MainWindow>().Show();
        }
    }
}
