using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Member_Login.Entities
{
    public enum UserRole_Enum { Admin, Member }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public UserRole_Enum UserRole { get; set; }
    }
}
