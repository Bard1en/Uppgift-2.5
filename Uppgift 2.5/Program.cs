using System;
 namespace Uppgift2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en multiplication med två decimaltal");
            string gånger = Console.ReadLine();
            int mellanslagsIndex = gånger.IndexOf("*");
            string förstatalet = gånger[..mellanslagsIndex];
            string andratalet = gånger[(mellanslagsIndex + 1)..];

            double första = double.Parse(förstatalet);
            double andra = double.Parse(andratalet);

            double sum = första * andra;
            Console.WriteLine("Dina tal multiplicerade med varandra blir " + sum);
            Console.ReadKey();




        }
    }
}