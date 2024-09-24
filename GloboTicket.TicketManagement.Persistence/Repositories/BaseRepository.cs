using GlobalTicket.TicketManagement.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Persistence.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            var result = await _dbContext.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size) =>
            await _dbContext.Set<T>()
            .Skip((page - 1) * size)
            .Take(size)
            .AsNoTracking().ToListAsync();

        public async Task<IReadOnlyList<T>> ListAllAsync() =>
            await _dbContext
            .Set<T>()
            .ToListAsync();

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();    
        }
    }
}
