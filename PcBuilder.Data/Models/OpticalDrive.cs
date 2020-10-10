using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class OpticalDrive
    {
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public int FormFactorTypeId { get; set; }
        public int? InterfaceTypeId { get; set; }
        public int? CapabilityTypeId { get; set; }
        public int? BufferCache { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual CapabilityType CapabilityType { get; set; }
        public virtual Category Category { get; set; }
        public virtual FormFactorType FormFactorType { get; set; }
        public virtual Interface InterfaceType { get; set; }
        public virtual ManufacturerType Manufacturer { get; set; }
    }
}
