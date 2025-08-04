using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShelf.DTO
{
    public class BookDTO
    {
        public class BookDisplay
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string AuthorName { get; set; }
        }
    }
}
