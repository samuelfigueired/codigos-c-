using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a altura do triângulo:");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a base do triângulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        double area = (baseTriangulo * altura) / 2;

        Console.WriteLine("A área do triângulo: " + area);
    }
}
