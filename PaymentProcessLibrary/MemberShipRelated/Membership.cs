using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PaymentProcessLibrary.MemberShipRelated
{
    public class Membership : IMembership
    {
        public Membership(int cost)
        {
            c = cost;
        }
        private bool _isActive;
        MemberShipClassification _membershipType;
        int c;
        public bool isActive { get => true;set { isActive = _isActive; } }

        public int cost { get => c; set { c = value; }  }

        public MemberShipClassification MembersipType { get => _membershipType; set { _membershipType = value; } }

        public MemberShipClassification GetMembership()
        {

            switch (cost)
            {               
                case 100:
                    return MemberShipClassification.basic;
                case 200:
                    return MemberShipClassification.vip;
                 default:
                    return MemberShipClassification.free;
            }
           
                
          

        }
    }
}
