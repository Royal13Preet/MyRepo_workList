using DataAccess.DBModel;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class Repo : IRepo
    {
        private readonly ProjectDBContext _dbContext;

        public Repo(ProjectDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool CreateProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteProduct(int productid)
        {
            var product = _dbContext.Products.Find(productid); 

            if (product == null)
            {
                return false; 
            }

            _dbContext.Remove(product); 
            _dbContext.SaveChanges(); 

            return true; 
        }


        public List<Category> GetCategoriesById(List<int> Categoryids)
        {
            return _dbContext.Categories.Where(c => Categoryids.Contains(c.Id)).ToList();
        }

        public Product GetProductById(int productid)
        {
            var product = _dbContext.Products
                 .Where(p => p.Id == productid)
                 .Include(p => p.ProductCategories)
                 .ThenInclude(p => p.Category).FirstOrDefault();
            return product!;
        }

        public bool UpdateProduct(Product product)
        {
             _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
