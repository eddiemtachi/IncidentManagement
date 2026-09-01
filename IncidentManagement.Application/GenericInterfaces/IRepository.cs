using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IncidentManagement.Application.GenericInterfaces
{
    public interface IRepository<T> where T : class
    {
        //This creates the interface which works with the entites
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);        
        void Delete(T entity);
    }
}
