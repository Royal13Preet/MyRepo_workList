using DataAccess;
using Manager_layer.DTo_s;

namespace Service_Layer
{
    public interface IService
    {
        public Product CreateProduct(CreateProductDto product);

        public IEnumerable<Product> GetProducts(int page, int pageSize, string? name);

        public Product UpdateProduct(int id, CreateProductDto product);

        public bool DeleteProduct(int id);

        public Product GetProductById(int id);

    }
}
