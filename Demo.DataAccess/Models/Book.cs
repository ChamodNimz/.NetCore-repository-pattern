using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DataAccess.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Book Title Must be provided")]
        [StringLength(50, MinimumLength = 2)]
        public string BookTitle { get; set; }

        [Required(ErrorMessage = "Publisher Name is must")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be with 2 to 100 characters")]
        public string Publisher { get; set; }

        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(1, 999)]
        public int Price { get; set; }

        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
