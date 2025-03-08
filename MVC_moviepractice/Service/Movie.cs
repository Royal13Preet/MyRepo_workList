using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_layer
{
    public class Movie
    {

        public string title { get; set; } = null!;

        public int year { get; set; }

        public List<string>? cast { get; set; }

        public List<string>? genres { get;  set; }

        public string? Thumbnail { get; set; } 
    }
}
