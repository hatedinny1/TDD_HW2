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
            this.actualPaid = booksCount * bookPrice;
        }
    }
}
