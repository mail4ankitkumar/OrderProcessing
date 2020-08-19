using PaymentProcessLibrary.ProductRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary.InvoiceRelated
{
    public class Invoice_Slip
    {   /// <summary>
    /// will include the list of product , in case of video a free video will also be added in this list
    /// </summary>
        public List<IProduct> Products; 
        public int Amount;
        public string ShippingAddress;
    }
}
