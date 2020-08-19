using PaymentProcessLibrary.InvoiceRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary.ProductRelated
{
    abstract class Product : IProduct
    {
 
        public int productId { get  
            
            {
                Random r = new Random();
                 return r.Next();
            } 
        }
        public  abstract int price { get; }
        public abstract Invoice_Slip GeneratePackingSlip();
        
    }
        
    
}
