using ProjectTemplate.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.SERVİCE.Abstract
{
    public interface IService
    {
        public List<Entity> GetEntities();
    }
}
