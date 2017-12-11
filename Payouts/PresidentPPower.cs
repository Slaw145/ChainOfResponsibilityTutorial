using System;
using System.Collections.Generic;
using System.Text;

namespace Purchase
{
    class PresidentPPower : PurchasePower
    {
        protected override double getAllowable()
        {
            return BASE * 60;
        }

        protected override string getRole()
        {
            return "President";
        }
    }
}
