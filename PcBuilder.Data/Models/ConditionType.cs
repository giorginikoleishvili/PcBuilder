using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class ConditionType
    {
        public ConditionType()
        {
            ProductStore = new HashSet<ProductStore>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductStore> ProductStore { get; set; }
    }
}
