using System;
using System.Collections.Generic;

namespace PayMoney
{
    enum QuantityPayingMoney
    {
        PayHundred,
        PayFifty,
        PayTwenty,
        PayFive
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Initializing objects
            Pay payHundred = new PayHundred();
            Pay payFifty = new PayFifty();
            Pay payTwenty = new PayTwenty();
            Pay payFive = new PayFive();

            //Setting elements of a one-way list
            payHundred.setPayOut(payFifty);
            payFifty.setPayOut(payTwenty);
            payTwenty.setPayOut(payFive);

            string option = Console.ReadLine();

            if (option=="1")
            {
                payHundred.ForwardRequest(QuantityPayingMoney.PayHundred);
            }
            else if (option == "2")
            {
                payHundred.ForwardRequest(QuantityPayingMoney.PayFifty);
            }
            else if (option == "3")
            {
                payHundred.ForwardRequest(QuantityPayingMoney.PayTwenty);
            }
            else if (option == "4")
            {
                payHundred.ForwardRequest(QuantityPayingMoney.PayFive);
            }

            Console.ReadKey();
        }
    }
}
