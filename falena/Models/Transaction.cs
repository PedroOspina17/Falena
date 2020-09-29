using falena.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace falena.Models
{
    public class Transaction
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public Employee Seller { get; set; }

        public Employee DeliveryMan { get; set; }

        [Required]
        public double DeliveryCost { get; set; }

        public double RealDeliveryCost { get; set; }

        [Required]
        public TransactionEnum.TransactionType TransactionType { get; set; }

        [MaxLength(2000)]
        public string Observations { get; set; }

        [Required]
        public TransactionEnum.TransactionStatus TransactionStatus { get; set; }

        [Required]
        public double SubTotal { get; set; }

        [Required]
        public double Total { get; set; }

        [Required]
        public List<TransactionDetail> Details { get; set; }
    }
}
