using NUnit.Framework;

namespace CodeKataOneTest
{
    [TestFixture]
    public class TestPriceOfBeans
    {
        [Test]
        public void SingleCanOfBeansPrice()
        {
            DiscountSuit suit = new DiscountSuit(3,1.0);
            Price price = new Price(1, 0.65);
            
            
            BuyingItem buyingItem = new BuyingItem("Beans",suit, price);
            Assert.AreEqual(0.65,buyingItem.getPrice());
        }

        [Test]
        public void ThreeCanOfBeansPrice()
        {
            DiscountSuit suit = new DiscountSuit(3, 1.0);
            Price price = new Price(3, 0.65);

            BuyingItem buyingItem = new BuyingItem("Beans",suit, price);
            Assert.AreEqual(1,buyingItem.getPrice());
        }

        [Test]
        public void FourCanOfBeansPrice()
        {
            DiscountSuit suit = new DiscountSuit(3, 1.0);
            Price price = new Price(4, 0.65);

            BuyingItem buyingItem = new BuyingItem("Beans",suit,price);
            Assert.AreEqual(1.65, buyingItem.getPrice());
        }
    }
}
