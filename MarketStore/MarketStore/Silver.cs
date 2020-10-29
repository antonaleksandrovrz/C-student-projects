using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Silver : Card
    {
        
        public Silver(float turnover, float purchaseValue) : base(purchaseValue)
        {
            base.discountRate = 2;
            if (turnover > 300) base.discountRate = 3.5f;
        }
    }
}
