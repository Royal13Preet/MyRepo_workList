using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.DataAccess.DBModel;

namespace WebProject.DataAccess.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly ProductDBContext _productDBContext;

        public ProductRepo(ProductDBContext productDBContext)
        {
            _productDBContext = productDBContext;
        }

        public bool Create(Product product)
        {
            _productDBContext.Products.Add(product);
            _productDBContext.SaveChanges();
            return true;

        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
