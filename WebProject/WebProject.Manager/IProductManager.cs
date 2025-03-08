using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.DataAccess.DBModel;
using WebProject.Manager.Dto_s;

namespace WebProject.Manager
{
    public interface IProductManager
    {
        public bool Create(CreateProductDto product);

        bool Update(CreateProductDto product);

        IEnumerable<Product> GetAllProduct();

        bool Delete(int id);
    }
}
