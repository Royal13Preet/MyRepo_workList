using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.Models.DBModels
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }


        public int AuthorId { get; set; }
        public virtual Author author { get; set; }

        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
