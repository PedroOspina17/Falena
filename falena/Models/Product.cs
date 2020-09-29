using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace falena.Models
{
    public class Product
    {
        [Required]
        [Key]

        public int Id { get; set; }
        [Required]
        [MaxLength (50)]
        public string Name { get; set; }
        [Required]
        public double  PriceList { get; set; }
        [DisplayName("Expected revenue")]
        public double ExpectedRevenue { get; set; }
        [DisplayName("Final price")]
        public double FinalPrice => PriceList + ExpectedRevenue;

        [DisplayName("Current stock")]
        public int CurrentStock { get; set; }

        public bool IsActive { get; set; }

    }
}
