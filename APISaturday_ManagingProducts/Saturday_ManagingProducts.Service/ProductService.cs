using Saturday_ManagingProducts.DataAccess.DBModel;
using Saturday_ManagingProducts.DataAccess.Repositories;
using Saturday_ManagingProducts.Manager.Dtos;

namespace Saturday_ManagingProducts.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _manager;

        public ProductService(IProductRepository manager)
        {
            _manager = manager;

        }

        public bool CreateNewProduct(ProductCreateRequestDto productDto)
        {
            var categories = _manager.GetCategoriesByIds(productDto.CategoryIds);

            var product = new Product
            {
                
                Name = productDto.Name,
                Price = productDto.Price,
                ProductCategories = categories.Select(c => new ProductCategory { Category = c }).ToList()
            };
            
            return _manager.AddProduct(product);
        }

        public ProductDto GetSingleProductById(int id)
        {
            var product = _manager.GetProductById(id);

            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ProductCategories = product.ProductCategories.Select(pc => new CategoryDto
                {
                    CategoryId = pc.CategoryId,
                    CategoryName = pc.Category.Name
                }).ToList()
            };
            

            return productDto;
        }

        public bool UpdateProduct(int id,ProductCreateRequestDto product)
        {
            var updatedProduct = _manager.GetProductById(id);
            if (updatedProduct == null)
            {
                return false;
            }

            var categories = _manager.GetCategoriesByIds(product.CategoryIds);

            updatedProduct.Name = product.Name;
            updatedProduct.Price = product.Price;
            updatedProduct.ProductCategories = categories.Select(c => new ProductCategory { Category = c }).ToList();

            _manager.UpdateProduct(updatedProduct);

            return true;
        }
    }
}
