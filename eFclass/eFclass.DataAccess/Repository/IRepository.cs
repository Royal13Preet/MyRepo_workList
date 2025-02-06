using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.DataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        ///Get all item
        
        public IEnumerable<T> GetAll();

        /// <summary>
        /// Get Item by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetSingle(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// getting a single or defalut
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public T GetSingleOrDefault(Expression<Func<T, bool>> predicate);
        /// <summary>
        /// adding 
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        void Update(T entity);
    }
}
