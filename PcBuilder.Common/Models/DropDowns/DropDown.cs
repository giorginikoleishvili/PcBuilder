using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Common.Models.DropDowns
{
    public class DropDown<T> : IDropDown<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
    }
}
