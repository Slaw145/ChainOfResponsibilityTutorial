using System;
using System.Collections.Generic;
using System.Text;

namespace PayMoney
{
    class PayHundred : Pay
    {
        public override void ForwardRequest(QuantityPayingMoney quantitypayingmoney)
        {
            if (quantitypayingmoney == QuantityPayingMoney.PayHundred)
            {
                Console.WriteLine("Pay out hundred dolars from cashpoint");
            }
            else if (pay != null)
            {
                pay.ForwardRequest(quantitypayingmoney);
            }
        }
    }
}
