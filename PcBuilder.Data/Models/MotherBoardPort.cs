using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class MotherBoardPort
    {
        public MotherBoardPort()
        {
            MotherBoardPortDetails = new HashSet<MotherBoardPortDetails>();
        }

        public int Id { get; set; }
        public int MotherBoardId { get; set; }
        public int? PortTypeId { get; set; }

        public virtual MotherBoard MotherBoard { get; set; }
        public virtual PortType PortType { get; set; }
        public virtual ICollection<MotherBoardPortDetails> MotherBoardPortDetails { get; set; }
    }
}
