using PcBuilder.Data.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Data.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        List<CategoryDto> GetCategories();
    }
}
