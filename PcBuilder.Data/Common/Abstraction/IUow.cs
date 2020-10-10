using PcBuilder.Data.Repositories.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Data.Common.Abstraction
{
    public interface IUow
    {
        CategoryRepository CategoryRepository { get; }
        void SaveChanges();
    }
}
