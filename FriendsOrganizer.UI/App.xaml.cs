using System.Windows;
using FriendsOrganizer.UI.Data;
using FriendsOrganizer.UI.ViewModel;

namespace FriendsOrganizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow(
                new MainViewModel(
                    new FriendDataService()));
            mainWindow.Show();
        }
    }
}
