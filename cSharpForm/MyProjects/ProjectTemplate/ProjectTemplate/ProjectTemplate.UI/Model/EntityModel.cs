using ProjectTemplate.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTemplate.UI.Model
{
    public class EntityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public RoleEnum Role { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
