using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class SlotType
    {
        public SlotType()
        {
            MotherBoardSlot = new HashSet<MotherBoardSlot>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int HardwareTypeId { get; set; }

        public virtual HardwareType HardwareType { get; set; }
        public virtual ICollection<MotherBoardSlot> MotherBoardSlot { get; set; }
    }
}
