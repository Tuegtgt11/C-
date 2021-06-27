using System;

namespace Ex3
{
    class Ex3
    {
        static void Main(string[] args)
        {
            string[] weekday = new string[6] { "Mon", "Tue", "Wed", "Thu", "fri", "Sat" };
            int a;
            do
            {
                Console.WriteLine("Enter number: (1-7)");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 1 || a > 7);

            Console.WriteLine(weekday[a - 1]);
            Console.ReadKey();
        }
    }
}
