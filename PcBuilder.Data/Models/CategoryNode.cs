using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class CategoryNode
    {
        public int Id { get; set; }
        public int ParentCategoryId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
