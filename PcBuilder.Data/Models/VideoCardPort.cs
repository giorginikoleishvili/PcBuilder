using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class VideoCardPort
    {
        public VideoCardPort()
        {
            VideoCardPortDetails = new HashSet<VideoCardPortDetails>();
        }

        public int Id { get; set; }
        public int VideoCardId { get; set; }
        public int PortTypeId { get; set; }

        public virtual PortType PortType { get; set; }
        public virtual VideoCard VideoCard { get; set; }
        public virtual ICollection<VideoCardPortDetails> VideoCardPortDetails { get; set; }
    }
}
