using System;
using System.Collections.Generic;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            SATM U = new SATM();

            U.Elephant();
            bool A;
            do
            {
                System.Console.WriteLine("Enter you Pass : ");
                int Pass = int.Parse(Console.ReadLine());

                A = U.Check(Pass);
                if (A)
                {
                    U.ShowMenu (Pass);
                }
                else
                {
                    Console.WriteLine("*/*/*/*/*/*/*/* Password Not valid */*/*/*/*/*/*/*");
                }
            }
            while (A);
        }
    }
}
