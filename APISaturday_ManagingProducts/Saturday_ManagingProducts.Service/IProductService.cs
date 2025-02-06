using Saturday_ManagingProducts.Manager.Dtos;

namespace Saturday_ManagingProducts.Service
{
    public interface IProductService
    {

        public bool CreateNewProduct(ProductCreateRequestDto product);

        public ProductDto GetSingleProductById(int id);

        public bool UpdateProduct(int id,ProductCreateRequestDto product);

    }
}
