using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Bronze : Card
    {

        public Bronze(float turnover, float purchaseValue) : base(purchaseValue)
        {
            if (turnover < 100) base.discountRate = 0;
            else if (turnover < 300) base.discountRate = 1;
            else base.discountRate = 2.5f;
        }
    }
}
