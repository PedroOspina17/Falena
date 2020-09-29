using falena.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace falena.Models
{
    public class TransactionViewModel
    {

        [Required]
        public DateTime Date { get; set; }
        public int SellerId { get; set; }
        public string SellerName { get; set; }

        [Required]
        public double DeliveryCost { get; set; }

        [Required]
        public TransactionEnum.TransactionType TransactionType { get; set; }

        [MaxLength(2000)]
        public string Observations { get; set; }

        [Required]
        public double SubTotal { get; set; }

        [Required]
        public double Total { get; set; }

        [Required]
        public List<TransactionDetailViewModel> Details { get; set; }
    }
}
