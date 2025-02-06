namespace Service_layer
{
    public class Movie
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public List<string>? Cast { get; set; }

        public List<string>? genres { get; set; }

        public string? Thumbnail { get; set; }
    }
}
