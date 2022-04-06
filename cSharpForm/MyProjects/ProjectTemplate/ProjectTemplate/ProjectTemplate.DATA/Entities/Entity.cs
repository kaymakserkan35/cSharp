using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.DATA.Entities
{

    public enum RoleEnum
    {
        Admin, Member
    }

    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public RoleEnum Role { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
