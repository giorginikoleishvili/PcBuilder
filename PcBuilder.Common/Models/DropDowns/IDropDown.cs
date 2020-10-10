using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Common.Models.DropDowns
{
    public interface IDropDown<T>
    {
        T Id { get; set; }
        string Name { get; set; }
    }
}
