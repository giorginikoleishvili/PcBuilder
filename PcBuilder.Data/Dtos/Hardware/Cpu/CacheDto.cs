using System.Collections.Generic;
using PcBuilder.Data.Dtos.Common;

namespace PcBuilder.Data.Dtos.Hardware.Cpu
{
    public class CacheDto
    {
        public DropDownDto<int> CacheType { get; set; }
        public List<string> CacheName { get; set; }
    }
}