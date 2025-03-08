using Microsoft.Extensions.Logging;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.Managers;
using Thursday_ProductManagement.Managers.DTO;

namespace Thursday_ProductManagement.Services
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


        public IEnumerable<Product> GetAlltheProducts()
        {
            return _manager.GetAll();
        }

        public bool CreateNewProduct(ProductDto productDto)
        {

            return _manager.Create(productDto);

        }


        public bool DeleteProduct(int id)
        {
            return _manager.Delete(id);
        }

      

        public Product GetSingleProductById(int id)
        {
            try
            {
                return _manager.GetById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting the single product.");
                return default!;
            }
        }

        public bool UpdateProduct(int id, ProductDto productDto)
        {
            try
            {
                var updated = _manager.Update(id, productDto);
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




