using PracticeProductManagements.DataAccess.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProductManagements.DataAccess.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// Getting the all product list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts();

        /// <summary>
        /// Get the Product by it's ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Product GetProductByID(Guid Id);

        /// <summary>
        /// Add the new product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool AddProduct(Product product);

        /// <summary>
        /// For deleting the new product
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool DeleteProduct(Guid Id);

        /// <summary>
        /// For Updating the existing product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool UpdateProduct(Product product);
    }
}
