using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    enum PcType
    {
        desktopComputer, notebook, server
    }
    struct Computer
    {
        public Computer(PcType pcType, int memoryCapasity, double cpuClockSpeed, int CPU)
        {
            this.pcType = pcType;
            this.memoryCapasity = memoryCapasity;
            this.cpuClockSpeed = cpuClockSpeed;
            this.CPU = CPU;
        }

        public PcType pcType;
        public int memoryCapasity;
        public double cpuClockSpeed;
        public int CPU;

    }
}
