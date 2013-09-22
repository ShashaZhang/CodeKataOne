using System;
namespace CodeKataOneTest
{
    public class BuyingItem
    {
        private DiscountSuit discountSuit;

        private Price price;

        public BuyingItem(string name, DiscountSuit suit, Price price)
        {
            this.discountSuit = suit;
            this.price = price;
        }

        public double getPrice()
        {
            return price.getPrice(discountSuit);
        }

    }
}