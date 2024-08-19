using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountId { get; set; }

        public string CustomerAccountNumber { get; set; }

        public string Currency { get; set; }

        public decimal CustomerAccountBalance { get; set; }

        public string BankBrach { get; set; }


    }
}
