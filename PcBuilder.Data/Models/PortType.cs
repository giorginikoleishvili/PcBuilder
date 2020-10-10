using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class PortType
    {
        public PortType()
        {
            MotherBoardPort = new HashSet<MotherBoardPort>();
            VideoCardPort = new HashSet<VideoCardPort>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int HardwareTypeId { get; set; }

        public virtual HardwareType HardwareType { get; set; }
        public virtual ICollection<MotherBoardPort> MotherBoardPort { get; set; }
        public virtual ICollection<VideoCardPort> VideoCardPort { get; set; }
    }
}
