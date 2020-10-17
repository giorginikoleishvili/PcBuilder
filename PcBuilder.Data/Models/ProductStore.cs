using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class ProductStore
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoeyId { get; set; }
        public int Count { get; set; }
        public DateTime? ImportDate { get; set; }
        public int ConditionTypeId { get; set; }

        public virtual Category Categoey { get; set; }
        public virtual ConditionType ConditionType { get; set; }
    }
}
