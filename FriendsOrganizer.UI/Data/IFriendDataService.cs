using System.Collections.Generic;
using FriendsOrganizer.Model;

namespace FriendsOrganizer.UI.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}