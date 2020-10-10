using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Memory
    {
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public int TypeId { get; set; }
        public int Speed { get; set; }
        public int ModuleId { get; set; }
        public bool? HeatSpreader { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual Category Category { get; set; }
        public virtual Module Module { get; set; }
        public virtual MemoryType Type { get; set; }
    }
}
