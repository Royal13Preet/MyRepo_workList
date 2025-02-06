namespace Saturday_ManagingProducts.Manager.Dtos
{
    public class ProductDto
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<CategoryDto> ProductCategories { get; set; }


    }
}
