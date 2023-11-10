using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<T> GetAll => _context.Set<T>();

        public async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
        }

        public Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<T?> FindWeakEntityAsync(int pk1, int pk2)
        {
            return await _context.Set<T>().FindAsync(pk1, pk2);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<int?> DeleteByIdAsync(int id)
        {
            T? exist = await _context.Set<T>().FindAsync(id);
            if (exist != null)
            {
                _context.Set<T>().Remove(exist);
                return id;
            }
            return 0;
        }

        public Task UpdateAsync(T entity)
        {
            T? exist = _context.Set<T>().Find(entity.Id);
            _context.Entry(exist).CurrentValues.SetValues(entity);
            return Task.CompletedTask;
        }
    }
}
