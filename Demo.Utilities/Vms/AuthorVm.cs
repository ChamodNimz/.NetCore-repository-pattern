using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Utilities.Vms
{
    public class AuthorVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<BookVm> Books { get; set; }
    }
}
