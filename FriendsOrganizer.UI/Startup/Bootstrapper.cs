using Autofac;
using FriendsOrganizer.DataAccess;
using FriendsOrganizer.UI.ViewModel;
using FriendsOrganizer.UI.Data;

namespace FriendsOrganizer.UI.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();
            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();

            return builder.Build();
        }
    }
}
