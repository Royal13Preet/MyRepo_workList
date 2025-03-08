using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.DataAccess.DBModel;

namespace WebProject.DataAccess.Repository
{
    public interface IProductRepo
    {
       public bool Create(Product product);

        bool Update(Product product);

        IEnumerable<Product> GetAllProduct();

        bool Delete(int id);
    }
}
