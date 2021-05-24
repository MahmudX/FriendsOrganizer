using System;
using System.Threading.Tasks;
using FriendsOrganizer.Model;
using FriendsOrganizer.UI.Event;
using FriendsOrganizer.UI.Interfaces;
using Prism.Events;

namespace FriendsOrganizer.UI.ViewModel
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private readonly IFriendDataService friendDataService;
        private readonly IEventAggregator eventAggregator;

        public FriendDetailViewModel(IFriendDataService friendDataService,
            IEventAggregator eventAggregator)
        {
            this.friendDataService = friendDataService;
            this.eventAggregator = eventAggregator;
            eventAggregator.GetEvent<OpenFriendDetailViewEvent>()
                .Subscribe(OnOpenFriendDetailView);
        }

        private async void OnOpenFriendDetailView(Guid friendId)
        {
            await LoadAsync(friendId);
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
