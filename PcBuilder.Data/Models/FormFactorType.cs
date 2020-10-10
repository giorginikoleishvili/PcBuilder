using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class FormFactorType
    {
        public FormFactorType()
        {
            OpticalDrive = new HashSet<OpticalDrive>();
            Storage = new HashSet<Storage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int HardwareTypeId { get; set; }

        public virtual HardwareType HardwareType { get; set; }
        public virtual ICollection<OpticalDrive> OpticalDrive { get; set; }
        public virtual ICollection<Storage> Storage { get; set; }
    }
}
