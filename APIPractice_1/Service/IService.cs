using Manager_Layer.Dto_s;

namespace Service_Layer
{
    public interface IService
    {
        public ResponseDto CreteProduct(CreateProduct createProduct);

        ResponseDto GetById(int id);



        ResponseDto UpdateProduct(int id, CreateProduct updateProduct);

        bool DeleteProduct(int id);
    }
}
