using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class SlotDetails
    {
        public int Id { get; set; }
        public int SlotId { get; set; }
        public int? Count { get; set; }
        public string Name { get; set; }

        public virtual Slot Slot { get; set; }
    }
}
