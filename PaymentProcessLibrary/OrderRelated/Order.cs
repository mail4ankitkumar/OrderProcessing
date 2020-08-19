using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary
{
     public abstract class Order :IOrder
    {
        private int _amount;
        private int _quantity;
        private string _billingAddresss;
        private string _itemName;
        public int Amount { get => _amount; set { _amount = value; } }
        public int Quantity { get => _quantity; set { _quantity = value; } }

        public string BillingAddress { get => _billingAddresss; set { _billingAddresss = value; } }

        public string ItemName { get => _itemName; set { _itemName = value; } }
        public DateTime OrderDate => DateTime.Now;

        public int OrderId
        {
            get
            {
                Random r = new Random();
                return r.Next();
            }
        }

       
    }
}
