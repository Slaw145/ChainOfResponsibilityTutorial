using System;
using System.Collections.Generic;

namespace ChainOfResponsibilitySchema
{
    public enum TypeNumber
    {
        One,
        Two,
        Three
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Initializing objects
            Number one = new One();
            Number two = new Two();
            Number three = new Three();

            //Setting elements of a one-way list
            one.setNumber(two);
            two.setNumber(three);

            //An example of a set of numbers
            List<TypeNumber> QuestsOnToday=new List<TypeNumber> {
                TypeNumber.One,
                TypeNumber.Two,
                TypeNumber.Three
            };

            //Seek the right number
            foreach (var quest in QuestsOnToday)
            {
                one.ForwardRequest(quest);
            }

            Console.ReadKey();
        }
    }
}
