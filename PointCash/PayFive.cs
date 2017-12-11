using System;
using System.Collections.Generic;
using System.Text;

namespace PayMoney
{
    class PayFive : Pay
    {
        public override void ForwardRequest(QuantityPayingMoney quantitypayingmoney)
        {
            if (quantitypayingmoney == QuantityPayingMoney.PayFive)
            {
                Console.WriteLine("Pay out five dolars from cashpoint");
            }
            else if (pay != null)
            {
                pay.ForwardRequest(quantitypayingmoney);
            }
        }
    }
}
