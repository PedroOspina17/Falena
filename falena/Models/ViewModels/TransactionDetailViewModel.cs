using falena.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace falena.Models
{
    public class TransactionDetailViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required] 
        public int ProductId { get; set; }
        public string ProductName { get; set; }
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
