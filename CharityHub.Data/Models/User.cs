﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharityHub.Data.Models
{
    public class User: IdentityUser<Guid>
    {
        [Required]
        [MaxLength(50)]
        public string DisplayName { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime LastLoginDate { get; set; }   

        public IList<Donation> Donations { get; set; }
        public IList<UserFollows> UserFollows { get; set; }
        public IList<AdminAction> AdminActions { get; set; }
    }
}
