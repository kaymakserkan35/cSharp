using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderA.BuilderClasses
{
    class ComputerBuilder : IComputerBuilder
    {
        public BIOS bios { get; set; }
        public GraphicCard graphicCard { get; set; }
        public HardDrive hardDrive { get; set; }

        public IComputerBuilder BuildBIOS()
        {
            this.bios = new BIOS();
            return this;
        }

        public IComputerBuilder BuildGraphicCard()
        {
            this.graphicCard = new GraphicCard();
            return this;
        }

        public IComputerBuilder BuildHardDrive()
        {
            this.hardDrive = new HardDrive();
            return this;
        }

        AbstractComputer IComputerBuilder.GetComputer()
        {
            return new Computer(this);
        }
    }
}
