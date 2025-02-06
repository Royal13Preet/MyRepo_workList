using AutoMapper;
using Microsoft.Extensions.Logging;
using Product_Managementmvc.DataAccess.DBModel;
using Product_Managementmvc.DataAccess.Repository;
using Product_Managementmvc.Managers.ProductDto;

namespace Product_Managementmvc.Managers
{
    public class ProductManager : IProductManager

    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;


        public ProductManager(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
   
        }

        public bool CreateProduct(ProductCreateDto dto)
        {
            var entity = _mapper.Map<Product>(dto);
            return _repository.Create(entity);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var entities = _repository.GetAll();
            return _mapper.Map<IEnumerable<Product>>(entities);
        }

        public Product GetProductById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<Product>(entity);
        }

        public bool UpdateProduct(int id, ProductCreateDto dto)
        {
            var entity = _repository.GetById(id);
            if (entity == null) return false;

            var updatedEntity = _mapper.Map(dto, entity);
            return _repository.Update(updatedEntity);
        }

        public bool DeleteProduct(int id)
        {
            return _repository.Delete(id);
        }


    }
}
