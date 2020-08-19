using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessLibrary.MemberShipRelated
{
    public interface IMembership
    {
        bool isActive { get; set; }
        int cost { get; set; }

        MemberShipClassification MembersipType { get; set; }
        MemberShipClassification GetMembership();



    }
}
