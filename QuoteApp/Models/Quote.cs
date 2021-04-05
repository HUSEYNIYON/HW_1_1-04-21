using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteApp.Models
{
    public class Quote
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Author { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
