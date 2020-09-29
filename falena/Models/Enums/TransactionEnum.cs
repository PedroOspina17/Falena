using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace falena.Models.Enums
{
    public class TransactionEnum
    {
        public enum TransactionType
        {
            sales = 1,
            purchales = 2
        }

        public enum TransactionStatus
        {
            Draft = 1,
            Confirmed = 2,
            Delivered = 3,
            DeliveryConfirmed = 4
        }
    }
}
