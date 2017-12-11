using System;
using System.Collections.Generic;
using System.Text;

namespace Purchase
{
    class ManagerPPower : PurchasePower
    {
        protected override double getAllowable()
        {
            return BASE * 10;
        }

        protected override string getRole()
        {
            return "Manager";
        }
    }
}
