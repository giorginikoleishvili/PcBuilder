using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class CacheType
    {
        public CacheType()
        {
            Cache = new HashSet<Cache>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cache> Cache { get; set; }
    }
}
