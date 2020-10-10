using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class HardwareType
    {
        public HardwareType()
        {
            ChipsetType = new HashSet<ChipsetType>();
            FormFactorType = new HashSet<FormFactorType>();
            Interface = new HashSet<Interface>();
            ManufacturerType = new HashSet<ManufacturerType>();
            MemoryType = new HashSet<MemoryType>();
            MicroArchitectureType = new HashSet<MicroArchitectureType>();
            PortType = new HashSet<PortType>();
            SeriesType = new HashSet<SeriesType>();
            SlotType = new HashSet<SlotType>();
            SocketType = new HashSet<SocketType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ChipsetType> ChipsetType { get; set; }
        public virtual ICollection<FormFactorType> FormFactorType { get; set; }
        public virtual ICollection<Interface> Interface { get; set; }
        public virtual ICollection<ManufacturerType> ManufacturerType { get; set; }
        public virtual ICollection<MemoryType> MemoryType { get; set; }
        public virtual ICollection<MicroArchitectureType> MicroArchitectureType { get; set; }
        public virtual ICollection<PortType> PortType { get; set; }
        public virtual ICollection<SeriesType> SeriesType { get; set; }
        public virtual ICollection<SlotType> SlotType { get; set; }
        public virtual ICollection<SocketType> SocketType { get; set; }
    }
}
