using Product_Managementmvc.DataAccess.DBModel;
using Product_Managementmvc.Managers.ProductDto;

namespace Product_Managementmvc.Services
{
    public interface IProductService
    {
        /// <summary>
        /// Retrieve the all Product
        /// </summary>
        /// <returns></returns>

        public IEnumerable<Product> GetAlltheProducts();

        /// <summary>
        /// Create a new Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>

        public bool CreateNewProduct(ProductCreateDto product);

        /// <summary>
        /// Update a Product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>

        public bool UpdateProduct(int id, ProductCreateDto product);

        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public bool DeleteProduct(int id);

        /// <summary>
        /// Get a Single product by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public Product GetSingleProductById(int id);

    }
}
