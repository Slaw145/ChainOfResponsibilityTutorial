using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilitySchema
{
    class Three : Number
    {
        public override void ForwardRequest(TypeNumber typenumber)
        {
            if (typenumber == TypeNumber.Three)
            {
                Console.WriteLine("The third request is supported");
            }
            else if (number != null)
            {
                number.ForwardRequest(typenumber);
            }
        }
    }
}
