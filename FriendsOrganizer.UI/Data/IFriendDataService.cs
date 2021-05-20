using FriendsOrganizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendsOrganizer.UI.Data
{
    public interface IFriendDataService
    {
        Task<List<Friend>> GetAllAsync();
    }
}