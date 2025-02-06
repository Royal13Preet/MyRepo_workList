using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IRepository
    {
        Product CreateProduct(Product product);

        public IEnumerable<Product> GetAllProducts();

        public Product UpdateProduct(Product product);

        public Product GetProductById(int id);  

        public bool DeleteProduct(int id); 
 
    }
}
