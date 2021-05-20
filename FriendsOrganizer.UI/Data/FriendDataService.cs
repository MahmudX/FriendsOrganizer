using FriendsOrganizer.DataAccess;
using FriendsOrganizer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

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
            Stopwatch stopwatch = new();
            stopwatch.Start();
            await using var ctx = contextCreator();
            var res = await ctx.Friends.ToListAsync();
            stopwatch.Stop();
            Debug.WriteLine("=!====================================!=");
            Debug.WriteLine(stopwatch.Elapsed);
            Debug.WriteLine("=!====================================!=");
            return res;
        }
    }
}
