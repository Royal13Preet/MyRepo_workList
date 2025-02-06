using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Saturday_ManagingProducts.DataAccess.DBModel;

namespace Saturday_ManagingProducts.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly AppDBContext _dbContext;

        public ProductRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddProduct(Product products)
        {
            var res = _dbContext.Products.Add(products);
            _dbContext.SaveChanges();
            return true;
        }

        public Product GetProductById(int id)
        {
            var product = _dbContext.Products
            .Where(p => p.Id == id)
            .Include(p => p.ProductCategories)
            .ThenInclude(pc => pc.Category)
            .FirstOrDefault();

            return product!;
        }

       
        public List<Category> GetCategoriesByIds(List<int> categoryIds)
        {
            return _dbContext.Categories.Where(c => categoryIds.Contains(c.Id)).ToList();
        }

        public bool UpdateProduct(Product products)
        {
            var product = _dbContext.Update(products);
            _dbContext.SaveChanges();
            return true;
        }
    }


}
