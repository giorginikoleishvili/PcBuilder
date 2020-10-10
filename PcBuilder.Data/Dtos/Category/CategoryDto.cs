using PcBuilder.Data.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Data.Dtos.Category
{
    public class CategoryDto
    {
        public int ParentId { get; set; }
        public string ParentName { get; set; }
        public List<DropDownDto<int>> Children { get; set; }
    }
}
