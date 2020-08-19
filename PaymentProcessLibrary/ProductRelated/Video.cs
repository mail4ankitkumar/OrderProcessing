using PaymentProcessLibrary.InvoiceRelated;
using PaymentProcessLibrary.ProductRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary
{
    class Video : Product
    {
        string _title;
        public  string Title { get =>_title; set {_title=value; } }

        public override int price => 70;

        public override Invoice_Slip GeneratePackingSlip()
        {
            Invoice_Slip s = new Invoice_Slip();
            s.Products.Add(new Video {Title= "learn the SKIE"});
            s.Products.Add(new Video { Title = "First Aid" });// free video
            return s;
        }
    }
}
