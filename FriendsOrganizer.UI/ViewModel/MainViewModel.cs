using System.Collections.ObjectModel;
using FriendsOrganizer.Model;
using FriendsOrganizer.UI.Data;

namespace FriendsOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IFriendDataService friendDataService;
        private Friend selectedFriend;

        public ObservableCollection<Friend> Friends { get; set; }

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

        public void Load()
        {
            Friends.Clear();
            foreach (var friend in friendDataService.GetAll())
            {
                Friends.Add(friend);
            }
        }


    }
}
