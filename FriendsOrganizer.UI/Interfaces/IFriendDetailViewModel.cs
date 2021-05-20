using System;
using System.Threading.Tasks;

namespace FriendsOrganizer.UI.Interfaces
{
    public interface IFriendDetailViewModel
    {
        Task LoadAsync(Guid friendId);
    }
}