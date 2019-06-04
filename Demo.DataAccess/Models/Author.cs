using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DataAccess.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Author Name Must be provided")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
