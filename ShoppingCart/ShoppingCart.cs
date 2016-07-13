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
            if (booksCount == 1)
            {
                this.actualPaid = bookPrice;
            }
            else
            {
                var booksMax = books.Max(x => x.Value);

                var uncheckedBooks = books.ToDictionary(x => x.Key, y => y.Value);

                for (int i = booksMax; i > 0; i--)
                {
                    var groupOfBooks = uncheckedBooks.Where(x => x.Value > 0).ToDictionary(x => x.Key, y => y.Value);
                    var groupOfBooksCount = groupOfBooks.Count();

                    var discount = this.discountComparison[groupOfBooksCount];
                    this.actualPaid += bookPrice * groupOfBooksCount * discount;

                    foreach (var g in groupOfBooks)
                    {
                        uncheckedBooks[g.Key]--;
                    }
                }
            }
        }
    }
}