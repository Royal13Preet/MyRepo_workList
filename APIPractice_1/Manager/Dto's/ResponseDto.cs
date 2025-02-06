namespace Manager_Layer.Dto_s
{
    public class ResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public List<CategoryDto> ProductCategories { get; set; }

    }
}
