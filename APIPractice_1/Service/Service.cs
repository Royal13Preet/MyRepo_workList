using DataAccess.DBModel;
using Manager_Layer;
using Manager_Layer.Dto_s;

namespace Service_Layer
{
    public class Service : IService
    {
        private readonly IManager _manager;

        public Service(IManager manager)
        {
            _manager = manager;
        }


        public ResponseDto CreteProduct(CreateProduct createProduct)
        {
            if (createProduct.CategoryIds == null || createProduct.CategoryIds.Count == 0)
            {
                throw new ArgumentException("Category field is required");
            }

            //var product = new Product
            //{
            //    Name = createProduct.Name,
            //    Price = createProduct.Price,
            //    Categories = category.Select(p => new ProductCategory { Category = p }).ToList()
            //};

            var createdProduct = _manager.CreateProduct(createProduct);

            //return new ResponseDto
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Price = product.Price,
            //    ProductCategories = product.Categories.Select(c => new CategoryDto
            //    {
            //        CategoryId = c.Category.Id,
            //        CategoryName = c.Category.Name
            //    }).ToList()
            //};

            return createdProduct;
        }


        public ResponseDto GetById(int id)
        {

            var product = _manager.GetById(id);

            //var productdto = new ResponseDto
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Price = product.Price,
            //    ProductCategories = product.Categories.Select(c => new CategoryDto
            //    {
            //        CategoryId = c.CategoryId,
            //        CategoryName = c.Category.Name,
            //    }).ToList()
            //};

            return product;
        }

        public ResponseDto UpdateProduct(int id, CreateProduct updateProduct)
        {

            if (updateProduct.CategoryIds == null || updateProduct.CategoryIds.Count == 0)
            {
                throw new ArgumentException("Category field is required");
            }

            //update.Name = updateProduct.Name;
            //update.Price = updateProduct.Price;
            //update.Categories = category.Select(c => new ProductCategory { Category = c }).ToList();

            var product = _manager.UpdateProduct(id,updateProduct);


            //return new ResponseDto
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Price = product.Price,
            //    ProductCategories = product.Categories.Select(c => new CategoryDto
            //    {
            //        CategoryId = c.Category.Id,
            //        CategoryName = c.Category.Name
            //    }).ToList()
            //};

            return product;
        }

        public bool DeleteProduct(int id)
        {
            return _manager.DeleteProduct(id);
        }
    }
}

