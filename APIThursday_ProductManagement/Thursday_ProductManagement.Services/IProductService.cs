using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Managers.DTO;

namespace Thursday_ProductManagement.Services
{
    public interface IProductService
    {
        /// <summary>
        /// DIsplaying the all Product List
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAlltheProducts();

        /// <summary>
        /// Creating a new Product
        /// </summary>
        /// <returns></returns>

        public bool CreateNewProduct(ProductDto product);

        /// <summary>
        /// Updating a Product
        /// </summary>
        /// <returns></returns>

        public bool UpdateProduct(int id, ProductDto product);

        /// <summary>
        /// Delting a Product
        /// </summary>
        /// <returns></returns>
        
        public bool DeleteProduct(int id);

        /// <summary>
        /// Get the single Product by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetSingleProductById(int id);
    }
}
