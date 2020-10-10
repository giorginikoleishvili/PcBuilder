using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class HeaderType
    {
        public HeaderType()
        {
            Header = new HashSet<Header>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Header> Header { get; set; }
    }
}
