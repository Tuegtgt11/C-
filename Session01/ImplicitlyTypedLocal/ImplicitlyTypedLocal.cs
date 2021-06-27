
class ImplicitlyTypedLocal
{

    static void Main(string[] args)
    {
        var i = 5;
        var s = "hello";
        var d = 1.0;
        //i is an interger
        Console.WriteLine("i*i: " + i * i);
        //s is a string
        Console.WriteLine("s in super case:" + s.ToUpper());
        //d is a double
        Console.WriteLine("type of d:" + d.GetType());
        Console.ReadLine();
    }
}