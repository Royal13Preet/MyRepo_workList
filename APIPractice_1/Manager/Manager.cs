using AutoMapper;
using DataAccess.DBModel;
using DataAccess.Repository;
using Manager_Layer.Dto_s;

namespace Manager_Layer
{
    public class Manager : IManager
    {

        private readonly IRepository _repositories;
        private readonly IMapper _mapper;

        public Manager(IRepository repositories, IMapper mapper)
        {
            _repositories = repositories;
            _mapper = mapper;
        }

        public ResponseDto CreateProduct(CreateProduct createProduct)
        {

            var category = _repositories.GetCategories(createProduct.CategoryIds);

            var invalidCategoryIds = createProduct.CategoryIds.Except(category.Select(c => c.Id)).ToList();

            if (invalidCategoryIds.Any())
            {
                throw new ArgumentException($"Invalid CategoryIds: {string.Join(", ", invalidCategoryIds)}.");
            }

            var entity = _mapper.Map<Product>(createProduct);

            var categories = _repositories.GetCategories(createProduct.CategoryIds);
            
            entity.Categories = categories.Select(c => new ProductCategory
            {
                CategoryId = c.Id,
                Product = entity
            }).ToList();
        
            var product = _repositories.CreateProduct(entity);

            return _mapper.Map<ResponseDto>(product);
        }

        public ResponseDto GetById(int id)
        {
            
            var entity = _repositories.GetById(id);

            return _mapper.Map<ResponseDto>(entity);

        }

        public List<Category> GetCategories(List<int> categoryId)
        {
            return _repositories.GetCategories(categoryId);
        }

        public ResponseDto UpdateProduct(int id,CreateProduct createProduct)
        {
            var isThere = _repositories.GetById(id);
            if (isThere == null)
            {
                throw new ArgumentException("Product with this Id not found");
            }

            var category = _repositories.GetCategories(createProduct.CategoryIds);

            var invalid = createProduct.CategoryIds.Except(category.Select(c => c.Id)).ToList();

            if (invalid.Any())
            {
                throw new ArgumentException($"Invalid CategoryIds: {string.Join(", ", invalid)}.");
            }

            var map = _mapper.Map(createProduct, isThere);

            map.Categories = category.Select(c => new ProductCategory
            {
                CategoryId = c.Id,
                Product = map
            }).ToList();

            var product = _repositories.UpdateProduct(map);

            return _mapper.Map<ResponseDto>(product);
        }

        public bool DeleteProduct(int id)
        {
            return _repositories.DeleteProduct(id);
        }
    }
}
