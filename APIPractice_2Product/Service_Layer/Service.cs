using DataAccess;
using Manager_layer;
using Manager_layer.DTo_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer
{
    public class Service : IService
    {

        private readonly IManager _manager;

        public Service(IManager manager)
        {
            _manager = manager;
        }
      
        public Product CreateProduct(CreateProductDto product)
        {
           return _manager.CreateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return _manager.DeleteProduct(id);
        }

        public IEnumerable<Product> GetProducts(int page, int pageSize, string? name)
        {

            var products = _manager.GetAllProducts();

            if (!string.IsNullOrEmpty(name)) 
            {
                products = products.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            }
            var pagination = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return pagination;

        }

        public Product UpdateProduct(int id,CreateProductDto product)
        {
            
            return _manager.UpdateProduct(id,product);
        }

        public Product GetProductById(int id) 
        {
            return _manager.GetProductById(id);
        }
    }
}
