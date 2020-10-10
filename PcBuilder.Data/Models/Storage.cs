using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        public int Capacity { get; set; }
        public int TypeId { get; set; }
        public int Cache { get; set; }
        public int? FormFactorId { get; set; }
        public int? InterfaceId { get; set; }
        public bool? Nvme { get; set; }
        public int VolumeTypeId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual FormFactorType FormFactor { get; set; }
        public virtual Interface Interface { get; set; }
        public virtual ManufacturerType Manufacturer { get; set; }
        public virtual StorageType Type { get; set; }
        public virtual VolumeType VolumeType { get; set; }
    }
}
