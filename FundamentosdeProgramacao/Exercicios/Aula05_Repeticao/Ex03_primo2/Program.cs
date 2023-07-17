internal class Program
{
    private static void Main(string[] args)
    {
        int num, i, cont = 0;

        Console.WriteLine("Digite um número  inteiro e positivo:");
        num = Convert.ToInt32(Console.ReadLine());

        for (i=1; i <= num; i++)
        {
            if (num % i == 0)
            {
                cont++;
            }
        }
        if (cont == 2)
            Console.WriteLine("O número {0} é primo.", num);
        else
            Console.WriteLine("O número {0} não é primo.", num);

        Console.ReadKey();
    }
}