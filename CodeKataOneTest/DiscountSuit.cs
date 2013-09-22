namespace CodeKataOneTest
{
    public class DiscountSuit
    {
        public int DiscountQuantity { get; set; }
        public double DiscountPrice { get; set; }

        public DiscountSuit(int quantity, double price)
        {
            this.DiscountQuantity = quantity;
            this.DiscountPrice = price;
        }


    }
}
