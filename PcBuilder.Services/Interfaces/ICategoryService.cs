using PcBuilder.Domains.Domains.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
