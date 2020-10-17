using System;
using System.Collections.Generic;

namespace PcBuilder.Data.Models
{
    public partial class SoldProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int SoldItemCount { get; set; }
        public DateTime? SellDate { get; set; }
    }
}
