using AutoMapper;
using PcBuilder.Data.Common.Abstraction;
using PcBuilder.Data.Dtos.Category;
using PcBuilder.Domains.Domains.Category;
using PcBuilder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public CategoryService(IUow uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public List<Category> GetCategories()
        {
            var categoryDtos = _uow.CategoryRepository.GetCategories();

            var categories = _mapper.Map<List<Category>>(categoryDtos);

            return categories;
        }

    }
}
