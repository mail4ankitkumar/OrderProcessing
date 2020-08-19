using PaymentProcessLibrary.InvoiceRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary
{
     public interface IProduct
    {    int productId { get;  }
         int price { get; }
         Invoice_Slip GeneratePackingSlip();
       
    }
}
