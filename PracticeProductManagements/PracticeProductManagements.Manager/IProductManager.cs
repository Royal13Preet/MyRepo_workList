using PracticeProductManagements.DataAccess.DBModel;
using PracticeProductManagements.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProductManagements.Manager
{
    public interface IProductManager
    {
        /// <summary>
        /// Get the all product details
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAlltheProducts();

        /// <summary>
        /// get the product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(Guid id);

        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="productdetailsdto"></param>
        /// <returns></returns>
        public Product AddNewProduct(ProductDetailsDto productdetailsdto);

        /// <summary>
        /// For deleting a existing product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemoveNewProduct(Guid id);

        /// <summary>
        /// For Updating a existing product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="productdetailsdto"></param>
        /// <returns></returns>
        public bool UpdateNewProduct(Guid id,ProductDetailsDto productdetailsdto);
    }
}
