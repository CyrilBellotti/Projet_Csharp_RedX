using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couche_Middleware
{
    public struct MachineInformation
    {
        // Variable qui sont suspectible de changer beaucoup de fois de valeur (d'où le public struct)
        public double infoDisk;
        public double infoRAM;
        public double infoCPU;
    }
}