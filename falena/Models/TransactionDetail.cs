using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace falena.Models
{
    public class TransactionDetail
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public Transaction TransactionHeader { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double CurrentProductPrice { get; set; }
        [Required]
        public double SellPrice { get; set; }
        [Required]
        public double Incomes { get; set; }
        [Required]
        public double SubTotal { get; set; }

    }
}
