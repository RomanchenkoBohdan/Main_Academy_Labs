using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    enum PcType
    {
        desktopComputer, notebook
    }
    struct Computer
    {
        public Computer(PcType pcType, int memoryCapasity, double cpuClockSpeed)
        {
            this.pcType = pcType;
            this.memoryCapasity = memoryCapasity;
            this.cpuClockSpeed = cpuClockSpeed;
        }

        public PcType pcType;
        public int memoryCapasity;
        public double cpuClockSpeed;

    }
}
