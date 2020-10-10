using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class VideoCardPortDetails
    {
        public int Id { get; set; }
        public int VideoCardPortId { get; set; }
        public string Name { get; set; }
        public int? Count { get; set; }

        public virtual VideoCardPort VideoCardPort { get; set; }
    }
}
