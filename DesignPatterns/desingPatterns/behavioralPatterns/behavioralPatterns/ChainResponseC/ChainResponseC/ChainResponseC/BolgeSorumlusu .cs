using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseC.ChainResponseC
{
    public class BolgeSorumlusu : Employee
    {
        public override void ProcessRequest(Domain req)
        {
            if (req.Amount <= 750000)
            {
                Console.WriteLine("{0} tarafından para çekme işlemi onaylandı #{1} TL",
                    this.GetType().Name, req.Amount);
            }
            else
            {
                throw new Exception(
                    $"Limit banka günlük işlem limitini aştığından para çekme işlemi #{req.Amount} TL onaylanmadı.");
            }
        }
    }
}
