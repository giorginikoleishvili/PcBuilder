using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Slot
    {
        public Slot()
        {
            SlotDetails = new HashSet<SlotDetails>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SlotTypeId { get; set; }

        public virtual MotherBoard Product { get; set; }
        public virtual VideoCard ProductNavigation { get; set; }
        public virtual SlotType SlotType { get; set; }
        public virtual ICollection<SlotDetails> SlotDetails { get; set; }
    }
}
