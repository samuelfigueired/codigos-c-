using System;

public class Calculator
{
    public static int Soma(int a, int b)
    {
        return a + b;
    }

    public static int Subt(int a, int b)
    {
        return a - b;
    }

    public static int Mult(int a, int b)
    {
        return a * b;
    }

    public static float Div(int a, int b)
    {
        if (b == 0)
        {
            throw new ArithmeticException("Erro: divisão por zero não é permitida!");
        }
        return (float)a / b;  // Conversão explícita para evitar divisão inteira
    }

    public static void Operacoes()
    {
        int a = 2, b = 3;

        Console.WriteLine("Soma: " + Soma(a, b));
        Console.WriteLine("Subtração: " + Subt(a, b));
        Console.WriteLine("Multiplicação: " + Mult(a, b));
        Console.WriteLine("Divisão: " + Div(a, b));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator.Operacoes();
    }
}
