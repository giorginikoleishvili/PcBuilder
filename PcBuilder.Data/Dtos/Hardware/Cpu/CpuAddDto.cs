using System.Collections.Generic;

namespace PcBuilder.Data.Dtos.Hardware.Cpu
{
    public class CpuAddDto
    {
        public string Name { get; set; }
        public int ManufactirerId { get; set; }
        public int CoreCount { get; set; }
        public double? CoreClock { get; set; }
        public double? BoostClock { get; set; }
        public int? SerieId { get; set; }
        public int? MicroarchitectureId { get; set; }
        public int SocketId { get; set; }
        public int? IntegratedGraphicId { get; set; }
        public int? SupportMemory { get; set; }
        public bool? EnableMultithreading { get; set; }
        public int? Tdp { get; set; }
        public int? Generation { get; set; }
        public int CategoryId { get; set; }
        public List<CacheDto> Caches { get; set; }
    }
}