using System;
using System.Collections.Generic;
using System.Text;

namespace Purchase
{
    class VicePresidentPPower : PurchasePower
    {
        protected override double getAllowable()
        {
            return BASE * 40;
        }

        protected override string getRole()
        {
            return "Vice President";
        }
    }
}
