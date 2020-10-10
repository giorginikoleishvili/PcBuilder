using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Port
    {
        public Port()
        {
            PortDetails = new HashSet<PortDetails>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? PortTypeId { get; set; }

        public virtual PortType PortType { get; set; }
        public virtual VideoCard PortTypeNavigation { get; set; }
        public virtual MotherBoard Product { get; set; }
        public virtual ICollection<PortDetails> PortDetails { get; set; }
    }
}
