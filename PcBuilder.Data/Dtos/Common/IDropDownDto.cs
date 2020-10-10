using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Data.Dtos.Common
{
    public interface IDropDownDto<T>
    {
        T Id { get; set; }
        string Name { get; set; }
    }
}
