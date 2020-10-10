using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Cooling
    {
        public Cooling()
        {
            VideoCard = new HashSet<VideoCard>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<VideoCard> VideoCard { get; set; }
    }
}
