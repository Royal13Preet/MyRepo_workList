using DataAccess.DBModel;
using DataAccess.Repository;
using Manager.Dto_s;

namespace Service_Layer
{
    public class Service : IService
    {
        private readonly IRepo _repository;

        public Service(IRepo repository)
        {
            _repository = repository;
        }

        public bool CreateNewProduct(CreateProduct productdto)
        {
            var getcategory = _repository.GetCategoriesById(productdto.CategoryIds);

            var product = new Product
            {
                Name = productdto.Name,
                Price = productdto.Price,
                ProductCategories = getcategory.Select(c => new ProductCategory { Category = c }).ToList()
            };

            return _repository.CreateProduct(product);

        }

        public bool DeleteProduct(int id)
        {
            return _repository.DeleteProduct(id);
        }

        public ResponseCreatedto GetProductId(int productid)
        {
            var response = _repository.GetProductById(productid);

            var productdto = new ResponseCreatedto
            {
                Id = response.Id,
                Name = response.Name,
                Price = response.Price,
                Categories = response.ProductCategories.Select(c => new CategoryDto
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.Category.Name
                }).ToList()
            };

            return productdto;

        }

        public bool UpdateNewProduct(int id,CreateProduct productdto)
        {

            var get = _repository.GetProductById(id);

            var response = _repository.GetCategoriesById(productdto.CategoryIds);

            get.Name = productdto.Name;
            get.Price = productdto.Price;
            get.ProductCategories = response.Select(c => new ProductCategory { Category = c}).ToList();

            return _repository.UpdateProduct(get);
            
           
        }
    }
}
