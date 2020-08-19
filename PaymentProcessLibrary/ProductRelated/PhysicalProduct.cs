using PaymentProcessLibrary.InvoiceRelated;
using PaymentProcessLibrary.ProductRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary
{
    class PhysicalProduct : Product,IPayment
    {
        public override int price => 100;

        public override Invoice_Slip GeneratePackingSlip()
        {
            throw new NotImplementedException();
        }

        public int payto()
        {
            throw new NotImplementedException();
        }
    }
}
