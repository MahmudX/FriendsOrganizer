using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FriendsOrganizer.Model;
using FriendsOrganizer.UI.Data;

namespace FriendsOrganizer.UI.ViewModel
{
    public class NavigationViewModel : INavigationViewModel
    {
        private readonly ILookupDataService lookupDataService;
        public ObservableCollection<LookupItem> Friends { get;  }   
        public NavigationViewModel(ILookupDataService lookupDataService)
        {
            this.lookupDataService = lookupDataService;
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
    }
}
