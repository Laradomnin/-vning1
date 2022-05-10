using System;

namespace övning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ditt namn.");
            string namn = Console.ReadLine();
            Console.WriteLine("Ange månadslön, " + namn);
            string lön = Console.ReadLine();
            Console.WriteLine( lön );
     
        }
    } 
}
