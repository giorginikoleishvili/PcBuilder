using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PcBuilder.Data.Common.Implementation;
using PcBuilder.Data.Dtos.Hardware.Cpu;
using PcBuilder.Data.Models;
using PcBuilder.Data.Repositories.Interfaces;

namespace PcBuilder.Data.Repositories.Classes
{
    public class CpuRepository : Repository<PcBuilder_DevContext, Cpu>, ICpuRepository
    {
        public CpuRepository(PcBuilder_DevContext entity) : base(entity)
        {
        }

        public void AddCpu(CpuAddDto cpuAdd)
        {
            var model = new Cpu
            {
                 Name = cpuAdd.Name,
                 ManufactirerId = cpuAdd.ManufactirerId,
                 CoreCount = cpuAdd.CoreCount,
                 CoreClock = cpuAdd.CoreClock,
                 SerieId = cpuAdd.SerieId,
                 MicroarchitectureId = cpuAdd.MicroarchitectureId,
                 BoostClock = cpuAdd.BoostClock,
                 SocketId = cpuAdd.SocketId,
                 IntegratedGraphicId = cpuAdd.IntegratedGraphicId,
                 SupportMemory = cpuAdd.SupportMemory,
                 EnableMultithreading = cpuAdd.EnableMultithreading,
                 Tdp = cpuAdd.Tdp,
                 Generation = cpuAdd.Generation,
                 CategoryId = cpuAdd.CategoryId,
                 Cache = cpuAdd.Caches.Select(x => new Cache
                 {
                     CashTypeId = x.CacheType.Id,
                     CachDetails = x.CacheName.Select(name => new CachDetails
                     {
                         Name = name
                     }).ToList(),
                 }).ToList()
            };

            Add(model);
            Context.SaveChanges();
        }
    }
}
