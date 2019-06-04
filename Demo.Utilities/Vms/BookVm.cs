using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Utilities.Vms
{
    public class BookVm
    {
        public int Id { get; set; }

        public string BookTitle { get; set; }

        public string Publisher { get; set; }

        public int GenreId { get; set; }

        public int Price { get; set; }

        public int AuthorId { get; set; }

        public AuthorVm Author { get; set; }

    }
}
