﻿using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.identity
{
    public partial class Aspnetroleclaim
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual Aspnetrole Role { get; set; }
    }
}