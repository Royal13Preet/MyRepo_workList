using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Layer.Dto_s
{
    public class CreateProduct
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        [Required]
        public List<int> CategoryIds { get; set; } = null!;
    }
}
