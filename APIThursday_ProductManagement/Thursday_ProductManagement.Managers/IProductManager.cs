using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Managers.DTO;

namespace Thursday_ProductManagement.Managers
{
    public interface IProductManager
    {
      
        /// <summary>
        /// Create a product
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        bool Create(ProductDto dto);

        /// <summary>
        /// Get All a Product
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetAll();

        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        ProductDto GetById(int id);

        /// <summary>
        /// Update a product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        bool Update(int id, ProductDto dto);

        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

        
    }
}
