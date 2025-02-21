class Program
{
    public static void Main(string[] args)
    {
        int cont = 0, x = 0;
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num == x)
        {
            Console.WriteLine("Número digitado é zero");
            cont++;
            Console.WriteLine("Contador: " + cont);    
        }
        else
        {
            num++;
            Console.WriteLine("Número digitado + 1: " + num);
            Console.WriteLine("Número digitado não é zero");
        }
    }
}
