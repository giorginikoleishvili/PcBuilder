using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Cooler
    {
        public int Id { get; set; }
        public int CoolerTypeId { get; set; }
        public string Name { get; set; }
        public int SocketId { get; set; }
        public int? WaterCooled { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual CoolerType CoolerType { get; set; }
        public virtual SocketType Socket { get; set; }
    }
}
