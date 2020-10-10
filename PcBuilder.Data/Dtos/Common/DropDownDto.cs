using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Data.Dtos.Common
{
    public class DropDownDto<T> : IDropDownDto<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
    }
}
