using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Card
    {
        protected float discountRate;
        private float purchaseValue;

        public Card(float purchaseValue)
        {
            this.purchaseValue = purchaseValue;
        }

        public void PrintReceipt()
        {
            Console.WriteLine();
            Console.WriteLine("****** SHOP NAME *******");
            Console.WriteLine("Purchase value: $" + purchaseValue);

            Console.WriteLine("Discount rate:" + discountRate + '%');

            float discount = purchaseValue * discountRate / 100;
            Console.WriteLine("Discount: $" + discount);

            Console.WriteLine("-------------------");
            Console.WriteLine("Total: $" + (purchaseValue - discount));
            Console.WriteLine("************************");

        }
    }
}
