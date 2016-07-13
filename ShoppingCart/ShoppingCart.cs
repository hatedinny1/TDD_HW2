using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        public Dictionary<int, double> discountComparison { get; private set; }

        public ShoppingCart()
        {
            this.discountComparison = new Dictionary<int, double> {
                { 1,1},
                { 2,0.95},
                { 3,0.9},
                { 4,0.8},
                { 5,0.75},
            };
        }

        public double actualPaid { get; set; }
        private const int bookPrice = 100;

        public void CalculateActualPaid(Dictionary<string, int> books)
        {
            var booksCount = books.Sum(x => x.Value);
            var shouldPaid = booksCount * bookPrice;
            this.actualPaid = shouldPaid * this.discountComparison[booksCount];
        }
    }
}