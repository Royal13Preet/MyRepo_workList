using DataAccess.DBModel;

namespace DataAccess.Repository
{
    public interface IRepo
    {
        public List<Category> GetCategoriesById(List<int> Categoryids);

        bool CreateProduct(Product product);

        Product GetProductById(int productid);

        bool UpdateProduct(Product product);

        bool DeleteProduct(int productid);
    }
}
