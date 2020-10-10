using PcBuilder.Common.Models.DropDowns;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Domains.Domains.Category
{
    public class Category
    {
        public int ParentId { get; set; }
        public string ParentName { get; set; }
        public List<DropDown<int>> Children { get; set; }
    }
}
