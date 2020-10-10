using Microsoft.EntityFrameworkCore;
using PcBuilder.Data.Common.Implementation;
using PcBuilder.Data.Dtos.Category;
using PcBuilder.Data.Dtos.Common;
using PcBuilder.Data.Models;
using PcBuilder.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PcBuilder.Data.Repositories.Classes
{
    public class CategoryRepository : Repository<PcBuilder_DevContext, Category>, ICategoryRepository
    {
        public CategoryRepository(PcBuilder_DevContext context) : base(context)
        {
        }

        public List<CategoryDto> GetCategories()
        {
            var categories = new List<CategoryDto>();
            var withCategory = Context.CategoryNode.Include(t => t.Category).ToList();
            var parents = withCategory.Where(x => x.CategoryId == x.ParentCategoryId).ToList();

            foreach (var parent in parents)
            {
                var children = Context.CategoryNode.Where(x => x.ParentCategoryId == parent.CategoryId && x.CategoryId != x.ParentCategoryId)
                                                                      .Select(y => new DropDownDto<int>
                                                                      {
                                                                          Id = y.Category.Id,
                                                                          Name = y.Category.Name
                                                                      }).ToList();
                var categoryDto = new CategoryDto
                {
                    ParentId = parent.CategoryId,
                    ParentName = parent.Category.Name,
                    Children = children
                };
                categories.Add(categoryDto);
            }

            return categories;
        }
    }
}
