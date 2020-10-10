using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class PowerSupply
    {
        public int Id { get; set; }
        public int EfficiencyRatingId { get; set; }
        public int ManufacturerId { get; set; }
        public int Wattage { get; set; }
        public int? TypeId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual Category Category { get; set; }
        public virtual EfficiencyRating EfficiencyRating { get; set; }
        public virtual ManufacturerType Manufacturer { get; set; }
        public virtual PowerSupplyType Type { get; set; }
    }
}
