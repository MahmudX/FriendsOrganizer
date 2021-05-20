using FriendsOrganizer.Model;
using FriendsOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendsOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IFriendDataService friendDataService;
        private Friend selectedFriend;

        public ObservableCollection<Friend> Friends { get; }

        public Friend SelectedFriend
        {
            get => selectedFriend;
            set
            {
                selectedFriend = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            this.friendDataService = friendDataService;
        }

        public async Task LoadAsync()
        {
            var friends = await friendDataService.GetAllAsync();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }
    }
}
