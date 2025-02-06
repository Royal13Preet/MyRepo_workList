using Product_Managementmvc.DataAccess.DBModel;
using Product_Managementmvc.Managers.ProductDto;

namespace Product_Managementmvc.Managers
{
    public interface IProductManager
    {
        /// <summary>
        /// Create a product
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        bool CreateProduct(ProductCreateDto dto);

        /// <summary>
        /// Get All a Product
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetAllProducts();

        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        Product GetProductById(int id);

        /// <summary>
        /// Update a product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        bool UpdateProduct(int id, ProductCreateDto dto);

        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteProduct(int id);
    }

}
