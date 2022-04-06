﻿using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.identity
{
    public partial class UserRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
