using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        public double actualPaid { get; set; }

        private const int bookPrice = 100;
        public void CalculateActualPaid(Dictionary<string, int> books)
        {
            var booksCount = books.Sum(x => x.Value);
            var shouldPaid = booksCount * bookPrice;
            if (booksCount == 1)
            {
                this.actualPaid = shouldPaid;
            }
            else if (booksCount == 2)
            {
                this.actualPaid = shouldPaid * 0.95;
            }
            else if (booksCount == 3)
            {
                this.actualPaid = shouldPaid * 0.9;
            }
        }
    }
}
