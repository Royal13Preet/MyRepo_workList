using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_ProductManagement.DataAccess.Repositories
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// For Creating a Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Create(T entity);

        /// <summary>
        /// Get the all Entities
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Get the entitie by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);
        /// <summary>
        /// Update the entities
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(T entity);

        /// <summary>
        /// Delete th enetity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
        
    }

}

