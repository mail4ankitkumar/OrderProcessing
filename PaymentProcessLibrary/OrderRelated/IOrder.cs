using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary
{
    public interface IOrder
    {
        int OrderId { get; }
        int Amount { get; set; }
        int Quantity { get; set; }

        string BillingAddress { get; set; }

        DateTime OrderDate { get; }
    }
}
