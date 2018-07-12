using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nmtLibrary.General.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int WriterID { get; set; }

        public virtual Writer Writer { get; set; }
    }
}
