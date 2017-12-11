using System;
using System.Collections.Generic;
using System.Text;

namespace Purchase
{
    class PurchaseRequest
    {

        private double amount;
        private string purpose;

        public PurchaseRequest(double amount)
        {
            this.amount = amount;
        }

        public double getAmount()
        {
            return amount;
        }

        public void setAmount(double amount)
        {
            this.amount = amount;
        }
    }
}
