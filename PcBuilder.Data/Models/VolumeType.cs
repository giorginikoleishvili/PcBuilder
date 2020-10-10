using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class VolumeType
    {
        public VolumeType()
        {
            Module = new HashSet<Module>();
            Storage = new HashSet<Storage>();
            VideoCard = new HashSet<VideoCard>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Module> Module { get; set; }
        public virtual ICollection<Storage> Storage { get; set; }
        public virtual ICollection<VideoCard> VideoCard { get; set; }
    }
}
