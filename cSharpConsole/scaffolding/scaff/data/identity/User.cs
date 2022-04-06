using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.identity
{
    public partial class User
    {
        public User()
        {
            Aspnetuserclaims = new HashSet<UserClaim>();
            Aspnetuserlogins = new HashSet<UserLogin>();
            Aspnetuserroles = new HashSet<UserRole>();
            Aspnetusertokens = new HashSet<UserToken>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<UserClaim> Aspnetuserclaims { get; set; }
        public virtual ICollection<UserLogin> Aspnetuserlogins { get; set; }
        public virtual ICollection<UserRole> Aspnetuserroles { get; set; }
        public virtual ICollection<UserToken> Aspnetusertokens { get; set; }
    }
}
