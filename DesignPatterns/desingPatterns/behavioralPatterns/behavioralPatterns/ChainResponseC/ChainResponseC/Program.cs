using ChainResponseC.ChainResponseC;
using System;
using System.Collections.Generic;

namespace ChainResponseC
{
    class Program
    {
        static void Main(string[] args)
        {

            var request1 = new Domain("a6e193dc-cdbb-4f09-af1a-dea307a9ed15", 480000, "TRY", "TR681223154132432141412");
            var request2 = new Domain("a6e193dc-cdbb-4f09-af1a-dea307a9ed15", 100000, "TRY", "TR681223154132432141412");
            var request3 = new Domain("a6e193dc-cdbb-4f09-af1a-dea307a9ed15", 50000, "TRY", "TR681223154132432141412");
            var request4 = new Domain("a6e193dc-cdbb-4f09-af1a-dea307a9ed15", 500, "TRY", "TR681223154132432141412");

            List<Domain> requestList = new List<Domain>(); requestList.Add(request4); requestList.Add(request3); requestList.Add(request2); requestList.Add(request1);

            Employee veznedar = new Veznedar();
            Employee yonetici = new Yonetici();
            Employee mudur = new Mudur();
            Employee bolgeSorumlusu = new BolgeSorumlusu();

            veznedar.SetNextApprover(yonetici);
            yonetici.SetNextApprover(mudur);
            mudur.SetNextApprover(bolgeSorumlusu);


            foreach (var request in requestList)
            {
                request.Process(veznedar);
                Console.WriteLine("----------------------------------------------------------------------------------");
            }

           

            Console.ReadKey();
        }
    }
}
