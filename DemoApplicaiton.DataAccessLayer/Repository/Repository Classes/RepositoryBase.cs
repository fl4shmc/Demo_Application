using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DemoApplicaiton.DataAccessLayer.Repository.Repository_Classes
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DemoContext _demoContext { get; set; }

        public RepositoryBase(DemoContext demoContext)
        {
            this._demoContext = demoContext;
        }

        public List<T> GetAll()
        {
            return _demoContext.Set<T>().ToList();
        }

        public async Task<T> GetById(int id)
        {
            return await _demoContext.Set<T>().FindAsync(id);
        }

        public async Task Create(T entity)
        {
            await _demoContext.Set<T>().AddAsync(entity);
        }

        public async Task Update(T entity)
        {
            try
            {
                _demoContext.Set<T>().Update(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task Delete(int id)
        {
            var entityId = await GetById(id);
            _demoContext.Set<T>().Remove(entityId);
        }

        public void SaveChanges()
        {
            this._demoContext.SaveChanges();
        }

        public async Task<List<T>> Search(Expression<Func<T, bool>> expression)
        {
            try
            {
                return _demoContext.Set<T>().Where(expression).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }
    }
}
