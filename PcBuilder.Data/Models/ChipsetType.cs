using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class ChipsetType
    {
        public ChipsetType()
        {
            MotherBoard = new HashSet<MotherBoard>();
            VideoCard = new HashSet<VideoCard>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? HardwareTypeId { get; set; }

        public virtual HardwareType HardwareType { get; set; }
        public virtual ICollection<MotherBoard> MotherBoard { get; set; }
        public virtual ICollection<VideoCard> VideoCard { get; set; }
    }
}
