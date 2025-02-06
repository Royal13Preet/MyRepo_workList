using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.DataAccess.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly BookContext _context;

        public BaseRepository(BookContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().First(predicate);

        }

        public T GetSingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public void Update(T entity) { 
            _context.Update<T>(entity);
            _context.SaveChanges();
        
        } 
    }
}
