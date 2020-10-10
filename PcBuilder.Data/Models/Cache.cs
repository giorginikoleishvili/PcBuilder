using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class Cache
    {
        public Cache()
        {
            CachDetails = new HashSet<CachDetails>();
        }

        public int Id { get; set; }
        public int CashTypeId { get; set; }
        public int CpuId { get; set; }

        public virtual CacheType CashType { get; set; }
        public virtual Cpu Cpu { get; set; }
        public virtual ICollection<CachDetails> CachDetails { get; set; }
    }
}
