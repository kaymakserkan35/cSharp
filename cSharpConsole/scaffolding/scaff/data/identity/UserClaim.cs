using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.identity
{
    public partial class Aspnetuserclaim
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual User User { get; set; }
    }
}
