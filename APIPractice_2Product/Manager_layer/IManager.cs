using DataAccess;
using Manager_layer.DTo_s;

namespace Manager_layer
{
    public interface IManager
    {
        public Product CreateProduct(CreateProductDto product);

        public IEnumerable<Product> GetAllProducts();

        public Product UpdateProduct(int id, CreateProductDto product);

        public bool DeleteProduct(int id);

        public Product GetProductById(int id);

       
    }
}
