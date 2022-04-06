using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderA.BuilderClasses
{
    class Computer : AbstractComputer
    {
       

        public Computer(ComputerBuilder builder)
        {
            this.bios = builder.bios;
            this.graphicCard = builder.graphicCard;
            this.hardDrive = builder.hardDrive;
        }

        //public BIOS bios { get; set; }
        //public GraphicCard graphicCard { get; set; }
        //public HardDrive hardDrive { get; set; }




    }
}
