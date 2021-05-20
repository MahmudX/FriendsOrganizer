using System;
using FriendsOrganizer.Model;
using System.Threading.Tasks;

namespace FriendsOrganizer.UI.Interfaces
{
    public interface IFriendDataService
    {
        Task<Friend> GetByIdAsync(Guid id);
    }
}