using System;
class AnonTypes
{
    static void Main(string[] args)
    {
        var p1 = new { Name = "A", Price = 3 };
        Console.WriteLine(" Name = {0}\n Price = {1}", p1.Name.ToLower(),p1.Price);
        Console.ReadLine();
    }
}