using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class MicroArchitectureType
    {
        public MicroArchitectureType()
        {
            Cpu = new HashSet<Cpu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? HardwareTypeId { get; set; }

        public virtual HardwareType HardwareType { get; set; }
        public virtual ICollection<Cpu> Cpu { get; set; }
    }
}
