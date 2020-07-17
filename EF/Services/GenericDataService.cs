using EntityFrameworkLibrary.DB;
using EsportManagementApp.Models;
using EsportManagementApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLibrary.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {

        private readonly EsportMgmtDatabaseContextFactory _context;

        public GenericDataService(EsportMgmtDatabaseContextFactory databaseContext)
        {
            _context = databaseContext;
        }

        public async Task<T> Create(T entity)
        {
            using (EsportMgmtDatabaseContext context = _context.CreateDbContext())
            {
                var createdEntity = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdEntity.Entity;
            }
        }

        public async Task<bool> Delete(T entityToDelete)
        {
            using (EsportMgmtDatabaseContext context = _context.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(x => x == entityToDelete);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (EsportMgmtDatabaseContext context = _context.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }

        public async Task<T> GetByID(int id)
        {
            using (EsportMgmtDatabaseContext context = _context.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(x => x.ID == id);
                return entity;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (EsportMgmtDatabaseContext context = _context.CreateDbContext())
            {
                entity.ID = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
