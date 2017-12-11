using System;
using System.Collections.Generic;
using System.Text;

namespace PayMoney
{
    class PayTwenty : Pay
    {
        public override void ForwardRequest(QuantityPayingMoney quantitypayingmoney)
        {
            if (quantitypayingmoney == QuantityPayingMoney.PayTwenty)
            {
                Console.WriteLine("Pay out twenty dolars from cashpoint");
            }
            else if (pay != null)
            {
                pay.ForwardRequest(quantitypayingmoney);
            }
        }
    }
}
