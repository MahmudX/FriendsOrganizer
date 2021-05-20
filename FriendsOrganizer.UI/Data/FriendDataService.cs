using FriendsOrganizer.DataAccess;
using FriendsOrganizer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using FriendsOrganizer.UI.Interfaces;

namespace FriendsOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private readonly Func<FriendOrganizerDbContext> contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            this.contextCreator = contextCreator;
        }
        public async Task<Friend> GetByIdAsync(Guid id)
        {
            await using var ctx = contextCreator();

            return await ctx.Friends.AsNoTracking().SingleAsync(f=>f.Id == id);
        }
    }
}
