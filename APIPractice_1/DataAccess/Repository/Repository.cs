using DataAccess.DBModel;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public Product CreateProduct(Product product)
        {
            var products = _context.Products.Add(product);
            _context.SaveChanges();
            return products.Entity;
        }

        public Product GetById(int id)
        {
            var product = _context.Products.Where(x => x.Id == id)
                .Include(x => x.Categories)
                .ThenInclude(x => x.Category).
                FirstOrDefault();
            return product!;
        }

        public List<Category> GetCategories(List<int> categoryId)
        {
            return _context.Categories.Where(p => categoryId.Contains(p.Id)).ToList();
        }

        public Product UpdateProduct(Product product)
        {
            var products = _context.Products.Update(product);
            _context.SaveChanges();
            return products.Entity;
        }

        public bool DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Remove(product);
                _context.SaveChanges();
                return true;
            }
            return false;

        }

    }
}






