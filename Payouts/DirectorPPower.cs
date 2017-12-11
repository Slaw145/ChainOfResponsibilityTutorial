using System;
using System.Collections.Generic;
using System.Text;

namespace Purchase
{
    class DirectorPPower : PurchasePower
    {
        protected override double getAllowable()
        {
            return BASE * 20;
        }

        protected override string getRole()
        {
            return "Director";
        }
    }
}
