using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class OnBoardEthernet
    {
        public OnBoardEthernet()
        {
            MotherBoard = new HashSet<MotherBoard>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MotherBoard> MotherBoard { get; set; }
    }
}
