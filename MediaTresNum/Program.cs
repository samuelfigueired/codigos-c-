public class Aluno
{
    public static void MediaTresNum(int a, int b, int c)
    {
        double media = (a + b + c) / 3.0;
        System.Console.WriteLine("A média dos números " + a + ", " + b + " e " + c + " é: " + media);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Aluno.MediaTresNum(10, 20, 30);
    }
}
