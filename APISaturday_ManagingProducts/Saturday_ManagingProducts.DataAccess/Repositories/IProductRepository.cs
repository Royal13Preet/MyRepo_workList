using Saturday_ManagingProducts.DataAccess.DBModel;

namespace Saturday_ManagingProducts.DataAccess.Repositories
{
    public interface IProductRepository
    {
        public bool AddProduct(Product products);

        public Product GetProductById(int id);

        public bool UpdateProduct(Product products);

        public List<Category> GetCategoriesByIds(List<int> categoryIds);
    }
}

