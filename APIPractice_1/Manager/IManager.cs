using DataAccess.DBModel;
using Manager_Layer.Dto_s;

namespace Manager_Layer
{
    public interface IManager
    {
        ResponseDto CreateProduct(CreateProduct createProduct);

        ResponseDto GetById(int id);

        public List<Category> GetCategories(List<int> categoryId);

        ResponseDto UpdateProduct(int id,CreateProduct createProduct);

        public bool DeleteProduct(int id);  
    }
}
