using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Gold : Card
    {
        
        public Gold(float turnover, float purchaseValue) : base(purchaseValue)
        {
            base.discountRate = 2;

            if (turnover > 100 && turnover < 800)
            {
                discountRate += turnover / 100;
            }

            else discountRate = 10;
        }
    }
}
