using ProjectTemplate.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.DATA.Context
{
    public class Context
    {
        public List<Entity> entities;
        public Context()
        {
            entities = new List<Entity>();
            for (int i = 1; i < 10; i++)
            {
                entities.Add(new Entity()
                {
                    Id = i,
                    Name = Faker.NameFaker.Name(),
                    Phone = Faker.PhoneFaker.Phone(),
                    CreatedDate = Faker.DateTimeFaker.DateTime(),
                    Role = (i % 2 == 0) ? RoleEnum.Admin : RoleEnum.Member
                });
            }
        }
    }
}
