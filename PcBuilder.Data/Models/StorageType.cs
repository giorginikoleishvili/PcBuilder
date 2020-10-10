using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class StorageType
    {
        public StorageType()
        {
            Storage = new HashSet<Storage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Storage> Storage { get; set; }
    }
}
