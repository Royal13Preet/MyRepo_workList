using Manager.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer
{
    public interface IService
    {
        bool CreateNewProduct(CreateProduct productdto);

        ResponseCreatedto GetProductId(int productid);

        bool UpdateNewProduct(int id,CreateProduct productdto);

        bool DeleteProduct(int id);
    }
}
