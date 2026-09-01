using IncidentManagement.Application.GenericInterfaces;
using IncidentManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IncidentManagement.Infrastructure.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        protected readonly IncidentDbContext Context;
        public EfRepository(IncidentDbContext context)
        {
            Context = context;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Context.Set<T>().FindAsync(id);
        } 
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }
        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await Context.Set<T>().Where(expression).ToListAsync();
        }
        public async Task AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
        }
        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        } 
    }
}
