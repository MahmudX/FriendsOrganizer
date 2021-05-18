using System.Collections.Generic;
using FriendsOrganizer.DataAccess;
using FriendsOrganizer.Model;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FriendsOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private readonly Func<FriendOrganizerDbContext> contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            this.contextCreator = contextCreator;
        }
        public async Task<List<Friend>> GetAllAsync()
        {
            await using var ctx = contextCreator();
            return await ctx.Friends.ToListAsync();
        }
    }
}
