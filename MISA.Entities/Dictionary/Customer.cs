using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entities
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public string TaxCodeNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PaymentCardCode { get; set; }
        public string TypeCard { get; set; }
        public string MoneyDebt { get; set; }
        public string Note { get; set; }
        public bool IsFiveFood { get; set; }
        public bool IsUnFollow { get; set; }
    }
}
