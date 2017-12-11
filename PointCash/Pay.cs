using System;
using System.Collections.Generic;
using System.Text;

namespace PayMoney
{
    abstract class Pay
    {
        protected Pay pay;

        public void setPayOut(Pay pay)
        {
            this.pay = pay;
        }

        public abstract void ForwardRequest(QuantityPayingMoney quantitypayingmoney);
    }
}
