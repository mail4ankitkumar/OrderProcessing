using PaymentProcessLibrary.MemberShipRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary
{
   public class ProductFactory
    {
        private  string _productType;
        public ProductFactory(string productType)
        {
            _productType = productType;
        }

        public IProduct GetProductObject()
        {
            switch (_productType)           
            {
                case "Book":
                    return new Book();
                //break;
                case "PhysicalProduct":
                    return new PhysicalProduct();
                case "Video":
                    return new Video();
                default:
                    break;
            }
           return null;
        }



    }

    public class MembershipFactory
    {

        private string _membershipType;
        public MembershipFactory(string MembershipType)
        {
            _membershipType = MembershipType;
        }

        public IMembership GetMembershipObject()
        {
            switch (_membershipType)
            {
                case "new":
                    return new Membership(100);
                //break;
                case "Upgrade":
                    return new Membership(200);
           
                default:
                    return new Membership(0);
            }
   
        }
    }
}
