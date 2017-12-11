using System;

namespace Purchase
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerPPower manager = new ManagerPPower();
            DirectorPPower director = new DirectorPPower();
            VicePresidentPPower vp = new VicePresidentPPower();
            PresidentPPower president = new PresidentPPower();
            manager.setSuccessor(director);
            director.setSuccessor(vp);
            vp.setSuccessor(president);

            try
            {
                while (true)
                {
                    Console.WriteLine("Enter the amount to check who should approve your expenditure.");
                    Console.Write(">");
                    double d = double.Parse(Console.ReadLine());
                    manager.processRequest(new PurchaseRequest(d));
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

            Console.ReadKey();
        }
    }
}
