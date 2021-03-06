﻿using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Interface
    {
        public Interface()
        {
            OpticalDrive = new HashSet<OpticalDrive>();
            Storage = new HashSet<Storage>();
            VideoCard = new HashSet<VideoCard>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int HardwareTypeId { get; set; }

        public virtual HardwareType HardwareType { get; set; }
        public virtual ICollection<OpticalDrive> OpticalDrive { get; set; }
        public virtual ICollection<Storage> Storage { get; set; }
        public virtual ICollection<VideoCard> VideoCard { get; set; }
    }
}
