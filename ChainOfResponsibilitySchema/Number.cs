using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilitySchema
{
    abstract class Number
    {
        protected Number number;

        public void setNumber(Number number)
        {
            this.number = number;
        }

        public abstract void ForwardRequest(TypeNumber typenumber);
    }
}
