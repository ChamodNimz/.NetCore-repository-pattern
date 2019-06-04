using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataAccess.Models
{
    public class BookGenres
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
