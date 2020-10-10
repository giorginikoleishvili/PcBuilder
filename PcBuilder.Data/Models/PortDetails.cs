using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class PortDetails
    {
        public int Id { get; set; }
        public int PortId { get; set; }
        public string Name { get; set; }
        public int? Count { get; set; }

        public virtual Port Port { get; set; }
    }
}
