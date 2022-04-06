using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseC.ChainResponseC
{
    class Veznedar : Employee
    {
        public override void ProcessRequest(Domain req)
        {
            if (req.Amount <= 40000)
            {
                Console.WriteLine("{0} tarafından para çekme i��lemi onaylandı #{1}",
                    this.GetType().Name, req.Amount);
            }
            else if (NextApprover != null)
            {
                Console.WriteLine("{0} TL işlem tutarı {1} max. limitini aştığından işlem yöneticiye gönderildi.", req.Amount, this.GetType().Name);

                NextApprover.ProcessRequest(req);
            }
        }
    }
}
