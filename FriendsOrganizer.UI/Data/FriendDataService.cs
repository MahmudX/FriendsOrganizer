using System.Collections.Generic;
using FriendsOrganizer.Model;

namespace FriendsOrganizer.UI.Data
{
   public class FriendDataService : IFriendDataService
   {
        public IEnumerable<Friend> GetAll()
        {
            // TODO : Load Data From Real Database.
            yield return new Friend { FirstName = "Mahmudul", LastName = "Hasan"};
            yield return new Friend { FirstName = "Ariful", LastName = "Islam" };
            yield return new Friend { FirstName = "Zakir", LastName = "Hossen" };
            yield return new Friend { FirstName = "Ashiqur", LastName = "Rahman" };
        }
    }
}
