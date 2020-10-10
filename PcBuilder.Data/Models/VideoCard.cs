using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class VideoCard
    {
        public VideoCard()
        {
            VideoCardPort = new HashSet<VideoCardPort>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public int ChipsetId { get; set; }
        public int Capacity { get; set; }
        public int? CoreClock { get; set; }
        public int? BoostClock { get; set; }
        public int? InterfaceId { get; set; }
        public int? ColorId { get; set; }
        public int? FrameSyncTypeId { get; set; }
        public int? Tdp { get; set; }
        public int CoolingTypeId { get; set; }
        public int? ExternalPowerTypeId { get; set; }
        public int VolumeTypeId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ChipsetType Chipset { get; set; }
        public virtual Color Color { get; set; }
        public virtual Cooling CoolingType { get; set; }
        public virtual ExternalPowerType ExternalPowerType { get; set; }
        public virtual FrameSyncType FrameSyncType { get; set; }
        public virtual Interface Interface { get; set; }
        public virtual ManufacturerType Manufacturer { get; set; }
        public virtual VolumeType VolumeType { get; set; }
        public virtual ICollection<VideoCardPort> VideoCardPort { get; set; }
    }
}
