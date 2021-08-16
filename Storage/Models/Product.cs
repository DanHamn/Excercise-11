using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        public string Name { get; set; }
        [Range(0.0, double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        [Required(ErrorMessage = "Please enter Category name"), MaxLength(30)]
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
         
    }
}
