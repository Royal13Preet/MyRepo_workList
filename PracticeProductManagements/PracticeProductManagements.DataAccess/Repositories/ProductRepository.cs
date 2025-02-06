using AutoMapper;
using Microsoft.Extensions.Logging;
using PracticeProductManagements.DataAccess.DBModel;


namespace PracticeProductManagements.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        
        private readonly ProductDbContext _productDbContext;
        private readonly ILogger<ProductRepository> _logger;
        private readonly IMapper _mapper;

        public ProductRepository(ProductDbContext productDbContext, ILogger<ProductRepository> logger, IMapper mapper)
        {
            _productDbContext = productDbContext;
            _logger = logger;
            _mapper = mapper;
        }
        
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return _productDbContext.Products;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching all products.");
                return Enumerable.Empty<Product>();

            }
        }
        
        public Product GetProductByID(Guid Id)
        {
            try
            {
                var product = _productDbContext.Products.FirstOrDefault(a => a.Id == Id);
                if (product == null)
                {
                    _logger.LogWarning("Product with ID {ProductId} not found.", Id);
                    return null!;
                }
                _logger.LogInformation("Fetched product by ID: {ProductId} successfully.", Id);
                return product;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while fetching the product with ID {Id}.");
                return null!;
            }
        }
        public bool AddProduct(Product product)
        {
            try
            {
                var res = _productDbContext.Products.Add(product);
                _productDbContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a new product.");
                return false;
            }

        }
        public bool DeleteProduct(Guid Id)
        {
            try
            {
                var result = _productDbContext.Products.FirstOrDefault(a => a.Id == Id);
                if (result != null)
                {
                    _productDbContext.Remove(result);
                    _productDbContext.SaveChanges();
                    return true;
                }

                _logger.LogWarning($"Product with ID {Id} not found for deletion.");
                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting the product with ID {Id}.");
                return false;
            }
        }
        public bool UpdateProduct(Product product)
        {
            try
            {
                _productDbContext.Products.Update(product);
                _productDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to update product.");
                return false;
            }
            

        }
    }
}


