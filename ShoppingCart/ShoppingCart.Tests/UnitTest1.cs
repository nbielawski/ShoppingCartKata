using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class UnitTest1
    {
        BronzeMember bronzeMember = new BronzeMember(1, "bob");
        SilverMember silver = new SilverMember(2, "shawn");
        GoldMember gold = new GoldMember(3, "Kenny");

        Cart cart = new Cart();

        Products productOne = new Products("gadget", 10.00m);

        Products productTwo = new Products("gizmo", 4m);

        Products productThree = new Products("whosiewhatsie", 9.50m);


        [TestMethod]
        public void BronzeMemberSHouldGetNoDiscount()
        {
            Assert.AreEqual(0, bronzeMember.GetDiscountPercent());
        }


        [TestMethod]
        public void SilverMemberShouldGetTenPercentDiscount()
        {
            Assert.AreEqual(.1m, silver.GetDiscountPercent());
        }


        [TestMethod]
        public void BronzeCartToatlSHouldEqualTen()
        {
            cart.AddItemToCart(productOne);
            Assert.AreEqual(10, cart.CalculateCartTotal(bronzeMember));
        }

        [TestMethod]
        public void SilverCartShouldEqualNine()
        {
            cart.AddItemToCart(productOne);
            Assert.AreEqual(9, cart.CalculateCartTotal(silver));
        }


        [TestMethod]
        public void GoldShouldEqualEight()
        {
            cart.AddItemToCart(productOne);
            Assert.AreEqual(8, cart.CalculateCartTotal(gold));
        }

        [TestMethod]
        public void TestAddandRemoveItemFromCart()
        {           
            cart.AddItemToCart(productOne);
            cart.AddItemToCart(productTwo);
            Assert.AreEqual(2, cart.CartItems.Count);

            cart.RemoveItemFromCart(productOne);
            Assert.AreEqual(1, cart.CartItems.Count);
        }

    }
}
