using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Header
    {
        public Header()
        {
            HeaderDetails = new HashSet<HeaderDetails>();
        }

        public int Id { get; set; }
        public int MotherBoardId { get; set; }
        public int HeaderTypeId { get; set; }

        public virtual HeaderType HeaderType { get; set; }
        public virtual MotherBoard MotherBoard { get; set; }
        public virtual ICollection<HeaderDetails> HeaderDetails { get; set; }
    }
}
