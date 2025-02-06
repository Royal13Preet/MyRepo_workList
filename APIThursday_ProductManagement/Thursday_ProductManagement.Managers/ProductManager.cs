using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Thursday_ProductManagement.DataAccess;
using Thursday_ProductManagement.DataAccess.Repositories;
using Thursday_ProductManagement.Managers.DTO;

namespace Thursday_ProductManagement.Managers
{
    public class ProductManager : IProductManager
        
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductManager> _logger;

        public ProductManager(IRepository<Product> repository, IMapper mapper, ILogger<ProductManager> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public bool Create(ProductDto dto)
        {
            var entity = _mapper.Map<Product>(dto);
            return _repository.Create(entity);
        }

        public IEnumerable<Product> GetAll()
        {
            var entities = _repository.GetAll();
            return _mapper.Map<IEnumerable<Product>>(entities);
        }

        public ProductDto GetById(int id)
        {
            var entity = _repository.GetById(id);
            return _mapper.Map<ProductDto>(entity);
        }

        public bool Update(int id, ProductDto dto)
        {
            var entity = _repository.GetById(id);
            if (entity == null) return false;

            var updatedEntity = _mapper.Map(dto, entity);
            return _repository.Update(updatedEntity);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

       

      
    }
}

