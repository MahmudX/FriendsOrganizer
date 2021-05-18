using System.Collections.Generic;
using System.Threading.Tasks;
using FriendsOrganizer.Model;

namespace FriendsOrganizer.UI.Data
{
    public interface IFriendDataService
    {
        Task<List<Friend>> GetAllAsync();
    }
}