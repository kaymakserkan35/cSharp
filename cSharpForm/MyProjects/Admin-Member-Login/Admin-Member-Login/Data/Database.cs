using Admin_Member_Login.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Member_Login.Data
{
    public class Database
    {
        public List<User> Users { get; set; }
        public Database()
        {
            Users = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                Users.Add(new User() { Id = i, Name = i.ToString(), Password = i.ToString(), RememberMe = (i % 2 == 0) ? true : false, UserRole = UserRole_Enum.Admin });
            }
        }
    }
}
