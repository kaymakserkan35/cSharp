using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderA.BuilderClasses
{
    abstract class AbstractComputer
    {
        public BIOS bios { get; set; }
        public GraphicCard graphicCard { get; set; }
        public HardDrive hardDrive { get; set; }
    }
}
