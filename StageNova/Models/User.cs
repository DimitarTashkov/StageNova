using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static StageNova.Common.Constants.ValidationConstants.UserConstants;

namespace StageNova.Models
{
    public class User
    {
        public User()
        {
            this.Orders = new HashSet<Order>();
            this.Tickets = new HashSet<Ticket>();
            this.UserRoles = new HashSet<UserRole>();
        }
        [Key]
        public Guid Id { get; set; } 

        [Required]
        [MaxLength(NameMaxLength)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; } = null!;
        public int? Age { get; set; }

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string AvatarUrl { get; set; } = null!;

        public HashSet<UserRole> UsersRoles { get; set; }
        = new HashSet<UserRole>();

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
