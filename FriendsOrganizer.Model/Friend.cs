using System;
using System.ComponentModel.DataAnnotations;

namespace FriendsOrganizer.Model
{
    public class Friend
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
    }
}
