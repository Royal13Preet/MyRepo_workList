using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_ProductManagement.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ProductDbContext _context;
        private readonly ILogger<Repository<T>> _logger;
        private readonly DbSet<T> _dbSet;

        public Repository(ProductDbContext context, ILogger<Repository<T>> logger)
        {
            _context = context;
            _logger = logger;
            _dbSet = _context.Set<T>();
        }

        public bool Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while adding entity");
                throw;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _dbSet;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching entities");
                throw;
            }
        }

        public T GetById(int id)
        {
            try
            {
                return _dbSet.Find(id)!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while fetching entity by ID");
                throw;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while updating entity");
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _dbSet.Find(id);
                if (entity == null) return false;

                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while deleting entity");
                throw;
            }
        }
    }
}
