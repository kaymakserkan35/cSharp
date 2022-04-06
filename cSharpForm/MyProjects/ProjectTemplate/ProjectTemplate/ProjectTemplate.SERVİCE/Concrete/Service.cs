using ProjectTemplate.DATA.Context;
using ProjectTemplate.DATA.Entities;
using ProjectTemplate.SERVİCE.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.SERVİCE.Concrete
{
    public class Service : IService
    {
        Context context;

        public Service(Context context)
        {
            this.context = context;
        }

        public List<Entity> GetEntities()
        {
            return context.entities;
        }
    }
}
