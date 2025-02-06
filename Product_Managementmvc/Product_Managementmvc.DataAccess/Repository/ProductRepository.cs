using Microsoft.Extensions.Logging;
using Product_Managementmvc.DataAccess.DBModel;

namespace Product_Managementmvc.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository(ProductDbContext context, ILogger<ProductRepository> logger) : base(context, logger) { }


    }
}
