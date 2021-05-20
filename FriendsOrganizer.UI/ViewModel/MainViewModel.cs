using System.Threading.Tasks;
using FriendsOrganizer.UI.Interfaces;

namespace FriendsOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public IFriendDetailViewModel FriendDetailViewModel { get; }
        public INavigationViewModel NavigationViewModel { get; }

        public MainViewModel(INavigationViewModel navigationViewModel,
            IFriendDetailViewModel friendDetailViewModel)
        {
            FriendDetailViewModel = friendDetailViewModel;
            NavigationViewModel = navigationViewModel;
        }

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }
    }
}
