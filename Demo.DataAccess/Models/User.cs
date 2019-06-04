using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.DataAccess.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Username { get; set; }
        [MaxLength(100)]
        public string Password { get; set; }
    }
}
