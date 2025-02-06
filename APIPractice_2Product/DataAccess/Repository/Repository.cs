namespace DataAccess.Repository
{
    public class Repository : IRepository
    {
        private readonly DataBaseApprochContext _context;

        public Repository(DataBaseApprochContext context)
        {
            _context = context;
        }

        public Product CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;


        }

        public Product GetProductById(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            return product!;
        }
        public Product UpdateProduct(Product product)
        {
            var products = _context.Products.Update(product);
            _context.SaveChanges();
            return products.Entity;
        }

        public bool DeleteProduct(int id)
        {
            var entity = _context.Products.Find(id);
            if (entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }

            return true;
        }
    }
}
