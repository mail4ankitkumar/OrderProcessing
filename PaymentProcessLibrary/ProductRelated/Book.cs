using PaymentProcessLibrary.InvoiceRelated;
using PaymentProcessLibrary.ProductRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary
{
    class Book : Product,IPayment
    {
        public override int price { get => 20;}

        public override Invoice_Slip GeneratePackingSlip()
        {
            return new Invoice_Slip() { Amount = price };

            //GenerateDuplicateSlip();
        }          
     
       
        public void GenerateDuplicateSlip()
        {

        }

        int IPayment.payto()
        {
            return 10 * price / 100;
            //assuming commision as 10 %
        }
    }
}
