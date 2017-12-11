using System;
using System.Collections.Generic;
using System.Text;

namespace Purchase
{
    abstract class PurchasePower
    {
        protected static double BASE = 500;
        protected PurchasePower successor;

        abstract protected double getAllowable();
        abstract protected string getRole();

        public void setSuccessor(PurchasePower successor)
        {
            this.successor = successor;
        }

        public void processRequest(PurchaseRequest request)
        {
            if (request.getAmount() < getAllowable())
            {
                Console.WriteLine(getRole() + " will approve $" + request.getAmount());
            }
            else if (successor != null)
            {
                successor.processRequest(request);
            }
        }
    }
}
