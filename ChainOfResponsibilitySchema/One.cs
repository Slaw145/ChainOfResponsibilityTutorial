using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilitySchema
{
    class One : Number
    {
        public override void ForwardRequest(TypeNumber typenumber)
        {
            if (typenumber == TypeNumber.One)
            {
                Console.WriteLine("The first request is supported");
            }
            else if (number != null)
            {
                number.ForwardRequest(typenumber);
            }
        }
    }
}
