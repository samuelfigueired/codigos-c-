class Program
{
    static void Main()
    {
        int a = 10, b = 3;
        double c = 15.0;

        Console.WriteLine("Valores = " + a + " " + b + " " + c);
        Console.WriteLine("A/B = " + (a / b));
        Console.WriteLine("A % B = " + (a % b));
        Console.WriteLine("C/B = " + (c / b));
        Console.WriteLine("Incremento de a =" + a++);
        Console.WriteLine("B % A = " + (b % a));
        Console.WriteLine("Decremento de a = " + b--);
        Console.WriteLine("C / 3 * A = " + (c / 3 * a));
        Console.WriteLine("C / (3 * A) = " + (c / (3 * a)));
        Console.WriteLine("a + b / 2 = " + (a + b / 2));
        Console.WriteLine("(a + b) / 2 = "+(a + b) / 2);
    }
}
