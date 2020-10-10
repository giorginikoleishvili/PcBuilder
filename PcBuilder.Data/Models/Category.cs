using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryNode = new HashSet<CategoryNode>();
            Cpu = new HashSet<Cpu>();
            Memory = new HashSet<Memory>();
            MotherBoard = new HashSet<MotherBoard>();
            OpticalDrive = new HashSet<OpticalDrive>();
            PowerSupply = new HashSet<PowerSupply>();
            Storage = new HashSet<Storage>();
            VideoCard = new HashSet<VideoCard>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CategoryNode> CategoryNode { get; set; }
        public virtual ICollection<Cpu> Cpu { get; set; }
        public virtual ICollection<Memory> Memory { get; set; }
        public virtual ICollection<MotherBoard> MotherBoard { get; set; }
        public virtual ICollection<OpticalDrive> OpticalDrive { get; set; }
        public virtual ICollection<PowerSupply> PowerSupply { get; set; }
        public virtual ICollection<Storage> Storage { get; set; }
        public virtual ICollection<VideoCard> VideoCard { get; set; }
    }
}
