using Microsoft.Extensions.Logging;
using Product_Managementmvc.DataAccess.DBModel;
using Product_Managementmvc.Managers;
using Product_Managementmvc.Managers.ProductDto;

namespace Product_Managementmvc.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductManager _manager;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductManager manager, ILogger<ProductService> logger)
        {
            _manager = manager;
            _logger = logger;
        }

        public bool CreateNewProduct(ProductCreateDto productDto)
        {
            return _manager.CreateProduct(productDto);
        }




        public bool DeleteProduct(int id)
        {
            return _manager.DeleteProduct(id);
        }

        public IEnumerable<Product> GetAlltheProducts()
        {
            return _manager.GetAllProducts();
        }

        public Product GetSingleProductById(int id)
        {
            try
            {
                return _manager.GetProductById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting the single product.");
                return default!;
            }
        }

        public bool UpdateProduct(int id, ProductCreateDto productDto)
        {
            try
            {
                var updated = _manager.UpdateProduct(id, productDto);
                if (updated)
                {
                    _logger.LogInformation("Product updated successfully.");
                }
                else
                {
                    _logger.LogWarning("Failed to update the product.");
                }
                return updated;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while updating the product.");
                return false;
            }
        }
    }
}
