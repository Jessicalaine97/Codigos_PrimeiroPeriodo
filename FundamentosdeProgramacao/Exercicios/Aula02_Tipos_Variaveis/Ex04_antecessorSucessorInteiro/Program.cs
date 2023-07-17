internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Digite um número inteiro:");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O antecessor do número {0} é {1} e seu sucessor é {2}.", num, num-1, num+1);
        Console.ReadKey();
    }
}