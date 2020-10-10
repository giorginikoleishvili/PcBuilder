using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class SocketType
    {
        public SocketType()
        {
            Cpu = new HashSet<Cpu>();
            MotherBoard = new HashSet<MotherBoard>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? HardwareTypeId { get; set; }

        public virtual HardwareType HardwareType { get; set; }
        public virtual ICollection<Cpu> Cpu { get; set; }
        public virtual ICollection<MotherBoard> MotherBoard { get; set; }
    }
}
