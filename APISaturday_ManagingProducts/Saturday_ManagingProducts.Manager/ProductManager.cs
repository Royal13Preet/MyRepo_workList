//using AutoMapper;
//using Saturday_ManagingProducts.DataAccess.Repositories;
//using Saturday_ManagingProducts.Manager.Dtos;

//namespace Saturday_ManagingProducts.Manager
//{
//    public class ProductManager : IProductManager
//    {
//        private readonly IProductRepository _repository;
//        private readonly IMapper _mapper;

//        public ProductManager(IProductRepository repository, IMapper mapper)
//        {
//            _repository = repository;
//            _mapper = mapper;
//        }

//        public bool CreateNewProduct(ProductCreateRequestDto productDto)
//        {
//            var categories = _repository.GetCategoriesByIds(productDto.CategoryIds);
//            if (categories.Count != productDto.CategoryIds.Count)
//            {
//                return false;
//            }


//        }
//    }
//}
