using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilitySchema
{
    class Two : Number
    {
        public override void ForwardRequest(TypeNumber typenumber)
        {
            if (typenumber == TypeNumber.Two)
            {
                Console.WriteLine("The second request is supported");
            }
            else if (number != null)
            {
                number.ForwardRequest(typenumber);
            }
        }
    }
}
