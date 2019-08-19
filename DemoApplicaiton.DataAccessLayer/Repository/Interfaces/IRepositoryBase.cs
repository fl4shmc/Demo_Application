using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplicaiton.DataAccessLayer
{
    public interface IRepositoryBase<T>
    {
        List<T> GetAll();
        Task<List<T>> Search(Expression<Func<T, bool>> expression);
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
        void SaveChanges();
    }
}
