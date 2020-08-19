 using NUnit.Framework;
using PaymentProcessLibrary;
using PaymentProcessLibrary.MemberShipRelated;
using PaymentProcessLibrary.ProductRelated;
using System;

namespace OrderRuleEngineTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BookOrderTest()
        {
            ProductOrder order = new ProductOrder();
            order.BillingAddress = "Bangalore";
            order.ShippingAddress = "Ranchi";
            order.Quantity = 1;
            order.Type = ProductType.Book;
            order.ItemName = "Learning To Ski";

            ProductFactory productFactory = new ProductFactory("Book");
            var Book= productFactory.GetProductObject();
            var result = Book.GeneratePackingSlip();
            Assert.AreEqual(20, result.Amount,"Book ivoice should have same amount of book cost");

           var payment = (IPayment)Book;
            int commisionAmount = payment.payto();
            Assert.AreEqual(2, commisionAmount, "CommisionAmount Should Match");                
            
        }

        [Test]
        public void MembershipTest()
        {
            MembershipOrder order = new MembershipOrder();
            order.BillingAddress = "Bangalore";      
            order.Quantity = 1;
            order.Type = MembershipType.New;
         
            MembershipFactory membershipFactory = new MembershipFactory("new");
            var Membership = membershipFactory.GetMembershipObject();
            var result = Membership.GetMembership();
            Assert.AreEqual(MemberShipClassification.basic, result, "He should have Basic MEmbership");       

        }

        ///Similarly all the test can be wriiten 
    }
}