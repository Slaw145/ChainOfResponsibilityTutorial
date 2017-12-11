using System;
using System.Collections.Generic;

namespace OneWayList
{
    class Program
    {
        static void Main(string[] args)
        {
            var tune = new LinkedList<string>();

            tune.AddFirst("do"); // do
            tune.AddLast("so"); // do - so
            tune.AddAfter(tune.First, "re"); // do - re- so
            tune.AddAfter(tune.First.Next, "mi"); // do - re - mi- so
            tune.AddBefore(tune.Last, "fa"); // do - re - mi - fa- so
            tune.RemoveFirst(); // re - mi - fa - so
            tune.RemoveLast(); // re - mi - fa

            LinkedListNode<string> miNode = tune.Find("mi");

            tune.Remove(miNode); // re - fa
            tune.AddFirst(miNode); // mi- re - fa

            foreach (string s in tune)
                Console.Write(s+" ");

            Console.ReadKey();
        }
    }
}
