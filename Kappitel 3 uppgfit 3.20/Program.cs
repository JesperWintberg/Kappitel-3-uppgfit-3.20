using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt första ord");
            string ord1 = Console.ReadLine();
            Console.WriteLine("Skriv in ditt andra ord");
            string ord2 = Console.ReadLine();
            Console.WriteLine("Skriv in diit tredje ord");
            string ord3 = Console.ReadLine();

            string[] ordning = { ord1, ord2, ord3 };
            var ordningrätt = ordning.OrderBy(n => n);
            foreach (var namn in ordningrätt)
            {
                Console.WriteLine(namn);
            }
        }
    }
}
