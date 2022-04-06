using System;
using System.Collections.Generic;

#nullable disable

namespace linq_çalışmaları.data.identity
{
    public partial class Aspnetusertoken
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual User User { get; set; }
    }
}
