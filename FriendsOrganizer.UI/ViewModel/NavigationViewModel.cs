using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FriendsOrganizer.Model;
using FriendsOrganizer.UI.Event;
using FriendsOrganizer.UI.Interfaces;
using Prism.Events;

namespace FriendsOrganizer.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private readonly ILookupDataService lookupDataService;
        private readonly IEventAggregator eventAggregator;

        public NavigationViewModel(ILookupDataService lookupDataService,
            IEventAggregator eventAggregator)
        {
            this.lookupDataService = lookupDataService;
            this.eventAggregator = eventAggregator;
            Friends = new ObservableCollection<LookupItem>();
        }

        public async Task LoadAsync()
        {
            var lookup = await lookupDataService.GetFriendLookupAsync();
            Friends.Clear();
            foreach (var friend in lookup)
            {
                Friends.Add(friend);
            }
        }


        public ObservableCollection<LookupItem> Friends { get; }
        private LookupItem selectedFriend;

        public LookupItem SelectedFriend
        {
            get => selectedFriend;
            set
            {
                selectedFriend = value;
                OnPropertyChanged();
                if (selectedFriend != null)
                    eventAggregator.GetEvent<OpenFriendDetailViewEvent>()
                        .Publish(selectedFriend.Id);
            }
        }

    }
}
