using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class HeaderDetails
    {
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string Name { get; set; }
        public int? Count { get; set; }

        public virtual Header Header { get; set; }
    }
}
