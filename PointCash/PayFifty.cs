using System;
using System.Collections.Generic;
using System.Text;

namespace PayMoney
{
    class PayFifty : Pay
    {
        public override void ForwardRequest(QuantityPayingMoney quantitypayingmoney)
        {
            if (quantitypayingmoney == QuantityPayingMoney.PayFifty)
            {
                Console.WriteLine("Pay out fifty dolars from cashpoint");
            }
            else if (pay != null)
            {
                pay.ForwardRequest(quantitypayingmoney);
            }
        }
    }
}
