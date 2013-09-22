using System;

namespace CodeKataOneTest
{
    public class Price
    {
        public int quantity { get; set; }
        public double singlePrice { get; set; }

        public Price(int quantity, double singlePrice)
        {
            this.quantity = quantity;
            this.singlePrice = singlePrice;
        }

        public double getPrice(DiscountSuit suit)
        {
            return Math.Round(HavingSuit(suit)) * suit.DiscountPrice + Math.Round(SingleItemAfterSuit(suit)) * singlePrice;
        }

        private double SingleItemAfterSuit(DiscountSuit suit)
        {
            return quantity % suit.DiscountQuantity;
        }

        private double HavingSuit(DiscountSuit suit)
        {
            return quantity / suit.DiscountQuantity;
        }
    }
}
