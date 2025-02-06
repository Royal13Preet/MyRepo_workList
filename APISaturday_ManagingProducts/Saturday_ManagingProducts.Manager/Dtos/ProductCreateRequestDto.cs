namespace Saturday_ManagingProducts.Manager.Dtos
{
    public class ProductCreateRequestDto
    {

        public string Name { get; set; }

        public decimal Price { get; set; }

        public List<int> CategoryIds { get; set; }

    }
}
