using System;
using System.Threading.Tasks;
using FriendsOrganizer.Model;
using FriendsOrganizer.UI.Interfaces;

namespace FriendsOrganizer.UI.ViewModel
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private readonly IFriendDataService friendDataService;

        public FriendDetailViewModel(IFriendDataService friendDataService)
        {
            this.friendDataService = friendDataService;
        }

        public async Task LoadAsync(Guid friendId)
        {
            Friend = await friendDataService.GetByIdAsync(friendId);
        }

        private Friend friend;

        public Friend Friend
        {
            get => friend;
            private set
            {
                friend = value;
                OnPropertyChanged();
            }
        }

    }
}
