using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using falena.Models;

namespace falena.Mapping
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            CreateMap<TransactionViewModel, Transaction>();
            CreateMap<TransactionDetailViewModel, TransactionDetail>();
        }
    }
}
