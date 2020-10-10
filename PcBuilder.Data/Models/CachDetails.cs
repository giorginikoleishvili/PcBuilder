using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class CachDetails
    {
        public int Id { get; set; }
        public int CachId { get; set; }
        public string Name { get; set; }

        public virtual Cache Cach { get; set; }
    }
}
