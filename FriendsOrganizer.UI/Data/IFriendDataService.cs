using System;
using FriendsOrganizer.Model;
using System.Threading.Tasks;

namespace FriendsOrganizer.UI.Data
{
    public interface IFriendDataService
    {
        Task<Friend> GetByIdAsync(Guid id);
    }
}