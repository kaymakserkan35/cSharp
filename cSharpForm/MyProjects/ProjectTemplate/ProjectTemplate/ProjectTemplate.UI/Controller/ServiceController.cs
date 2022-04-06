using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.DATA.Entities;
using ProjectTemplate.SERVİCE.Abstract;
using ProjectTemplate.SERVİCE.Concrete;
using ProjectTemplate.UI.Model;

namespace ProjectTemplate.UI.Controller
{
    public class ServiceController
    {
        IService service;

        public ServiceController(IService service)
        {
            this.service = service;
        }

        public List<EntityModel> GetEntities()
        {
            var entitiesmodel = new List<EntityModel>();

            foreach (var entity in service.GetEntities())
            {
                entitiesmodel.Add(new EntityModel()
                {
                    Id = entity.Id,
                    CreatedDate = entity.CreatedDate,
                    Name = entity.Name,
                    Phone = entity.Phone,
                    Role = entity.Role
                });
            }

            return entitiesmodel;

        }
    }
}
