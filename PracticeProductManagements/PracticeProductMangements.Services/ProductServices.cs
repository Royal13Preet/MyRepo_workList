using Microsoft.Extensions.Logging;
using PracticeProductManagements.DataAccess.DBModel;
using PracticeProductManagements.Manager;
using PracticeProductManagements.Models.Dtos;

namespace PracticeProductMangements.Services
{
    public class ProductServices : IProductServices
    {

        private readonly IProductManager _manager;
        private readonly ILogger<ProductServices> _logger;

        public ProductServices(IProductManager manager, ILogger<ProductServices> logger)
        {
            _manager = manager;
            _logger = logger;
        }

        public Product AddNewProduct(ProductDetailsDto product)
        {
            try
            {
                _logger.LogInformation("Attempting to add a new product.");
                var result = _manager.AddNewProduct(product);

                _logger.LogInformation("Product added successfully.");
                return result;

            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a new product.");
                throw;
            }
        }
        public bool DeleteProduct(Guid id)
        {
            try
            {
                _logger.LogInformation("Attempting to delete product with ID {ProductId}.", id);
                var result = _manager.RemoveNewProduct(id);
                _logger.LogInformation("Product with ID {ProductId} deleted successfully.", id);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting product with ID {ProductId}.", id);
                return false;
            }
        }
        //public IEnumerable<ProductDetaislDto> GetAlltheProductDetails()
        //{
        //    try
        //    {
        //        _logger.LogInformation("Fetching all product details.");
        //        var products = _manager.GetAlltheProducts();
        //        _logger.LogInformation("Successfully fetched all product details.");
        //        return products;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "An error occurred while fetching all product details.");
        //        return Enumerable.Empty<ProductDetaislDto>();
        //    }
        //}
        public IEnumerable<Product> GetAlltheProductDetails(int page, int pageSize, string? name)
        {
            try
            {
                _logger.LogInformation("Fetching product details with pagination. Page: {Page}, PageSize: {PageSize}, Name filter: {Name}", page, pageSize, name);
                var products = _manager.GetAlltheProducts();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    products = products.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
                }

                var paginatedProducts = products
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                _logger.LogInformation("Successfully fetched {Count} product details.", paginatedProducts.Count);
                return paginatedProducts;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching product details with pagination.");
                throw;
            }
        }

        public Product GetProductDetails(Guid id)
        {
            try
            {
                _logger.LogInformation("Fetching details for product with ID {ProductId}.", id);
                var product = _manager.GetProductById(id);
                return product;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching details for product with ID {ProductId}.", id);
                throw;
            }
        }

        public bool UpdateProduct(Guid id, ProductDetailsDto productdetailsdto)
        {
            try
            {
                _logger.LogInformation("Attempting to update product.");
                var result = _manager.UpdateNewProduct(id, productdetailsdto);
                _logger.LogInformation("Product updated successfully.");
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the product.");
                return false;

            }
        }


    }
}







