using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DataAccess.Models
{
    public class Genre
    {
        public  int Id { get; set; }
        public string GenreName { get; set; }

        public List<Book> Books { get; set; }
    }
}
