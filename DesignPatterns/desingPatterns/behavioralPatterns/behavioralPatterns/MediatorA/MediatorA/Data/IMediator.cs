using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorA.Data
{
    public interface IMediator
    {
        public void Notify(AComponent sender, string Event);
    }
}
