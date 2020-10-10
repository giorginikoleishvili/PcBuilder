using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Cpu
    {
        public Cpu()
        {
            Cache = new HashSet<Cache>();
        }

        public int Id { get; set; }
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

        public virtual Category Category { get; set; }
        public virtual ManufacturerType Manufactirer { get; set; }
        public virtual MicroArchitectureType Microarchitecture { get; set; }
        public virtual SeriesType Serie { get; set; }
        public virtual SocketType Socket { get; set; }
        public virtual ICollection<Cache> Cache { get; set; }
    }
}
