using System;
using System.Collections.Generic;
using System.Text;
using PcBuilder.Data.Dtos.Hardware.Cpu;

namespace PcBuilder.Data.Repositories.Interfaces
{
    public interface ICpuRepository
    {
        void AddCpu(CpuAddDto cpuAdd);
    }
}
