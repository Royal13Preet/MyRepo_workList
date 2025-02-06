using PracticeProductManagements.DataAccess.DBModel;
using PracticeProductManagements.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProductMangements.Services
{
    public interface IProductServices
    {
        /// <summary>
        /// Get the all product details using the pagination
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public IEnumerable<Product> GetAlltheProductDetails(int page, int pageSize, string? name);

        /// <summary>
        /// Get the product details by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductDetails(Guid id);

        /// <summary>
        /// add the new product
        /// </summary>
        /// <param name="productdetailsdto"></param>
        /// <returns></returns>
        public Product AddNewProduct(ProductDetailsDto productdetailsdto);
        /// <summary>
        /// delete the new product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteProduct(Guid id);

        /// <summary>
        /// updating the existing product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="productdetailsdto"></param>
        /// <returns></returns>
        public bool UpdateProduct(Guid id,ProductDetailsDto productdetailsdto);
    }
}
