using System;

class Program
{
    public static void Main(string[] args)
    {
        double raio = 4;
        double areaCirculo = Math.PI * Math.Pow(raio, 2);

        Console.WriteLine("A área do círculo com raio " + raio + " é: " + areaCirculo);
    }
}
