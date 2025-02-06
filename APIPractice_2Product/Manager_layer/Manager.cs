using AutoMapper;
using DataAccess;
using DataAccess.Repository;
using Manager_layer.DTo_s;
using System.Linq.Expressions;

namespace Manager_layer
{
    public class Manager : IManager
    {

        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public Manager(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Product CreateProduct(CreateProductDto product)
        {
            var entity = _mapper.Map<Product>(product);
            return _repository.CreateProduct(entity);
        }

        
        public bool DeleteProduct(int id)
        {
            //var isIdThere = _repository.GetProductById(id);
            //if(isIdThere == null)
            //{
            //    throw new Exception("Id is not there");
            //}
            return _repository.DeleteProduct(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public Product UpdateProduct(int id, CreateProductDto product)
        {
            var productId = _repository.GetProductById(id);
            if (productId == null)
            {
                throw new Exception("Product with this not found");
            }
            
            var products = _mapper.Map(product, productId);

            var upDated = _repository.UpdateProduct(products);

            return upDated;
        }

    }
}
