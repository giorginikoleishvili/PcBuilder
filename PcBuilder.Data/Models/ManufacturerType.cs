using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class ManufacturerType
    {
        public ManufacturerType()
        {
            Cpu = new HashSet<Cpu>();
            OpticalDrive = new HashSet<OpticalDrive>();
            PowerSupply = new HashSet<PowerSupply>();
            Storage = new HashSet<Storage>();
            VideoCard = new HashSet<VideoCard>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? HardwareTypeId { get; set; }

        public virtual HardwareType HardwareType { get; set; }
        public virtual ICollection<Cpu> Cpu { get; set; }
        public virtual ICollection<OpticalDrive> OpticalDrive { get; set; }
        public virtual ICollection<PowerSupply> PowerSupply { get; set; }
        public virtual ICollection<Storage> Storage { get; set; }
        public virtual ICollection<VideoCard> VideoCard { get; set; }
    }
}
