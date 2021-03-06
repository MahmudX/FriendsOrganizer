using FriendsOrganizer.DataAccess;
using FriendsOrganizer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendsOrganizer.UI.Interfaces;

namespace FriendsOrganizer.UI.Data
{
    public class LookupDataService : ILookupDataService
    {
        private readonly Func<FriendOrganizerDbContext> contextCreator;

        public LookupDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            this.contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetFriendLookupAsync()
        {
            await using var ctx = contextCreator();
            return await ctx.Friends.AsNoTracking().Select(f =>
                new LookupItem()
                {
                    Id = f.Id,
                    DisplayMember = f.FirstName + " " + f.LastName
                })
                .ToListAsync();
        }
    }
}
