using DataAccess.DBModel;

namespace DataAccess.Repository
{
    public interface IRepository
    {
        Product CreateProduct(Product product);

        List<Category> GetCategories(List<int> categoryId);

        Product GetById(int id);

        Product UpdateProduct(Product product);    

        bool DeleteProduct(int id);

    }
}
