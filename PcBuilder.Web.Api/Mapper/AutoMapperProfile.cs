using AutoMapper;
using PcBuilder.Common.Models.DropDowns;
using PcBuilder.Data.Dtos.Category;
using PcBuilder.Data.Dtos.Common;
using PcBuilder.Domains.Domains.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcBuilder.Web.Api.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CategoryDto,Category>().ReverseMap();
            CreateMap<DropDownDto<int>,DropDown<int>>().ReverseMap();
        }
    }
}
