using Microsoft.EntityFrameworkCore;
using PcBuilder.Data.Common.Abstraction;
using PcBuilder.Data.Models;
using PcBuilder.Data.Repositories.Classes;
using PcBuilder.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PcBuilder.Data.Common.Implementation
{
    public class Uow : IUow, IDisposable
    {
        private PcBuilder_DevContext Entity;
        public PcBuilder_DevContext Context
        {
            get
            {
                Entity = Entity ?? new PcBuilder_DevContext();
                return Entity;
            }
        }
        private CategoryRepository categoryRepository;
        public CategoryRepository CategoryRepository
        {
            get
            {

                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new CategoryRepository(Context);
                }
                return categoryRepository;
            }
        }



        #region Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
