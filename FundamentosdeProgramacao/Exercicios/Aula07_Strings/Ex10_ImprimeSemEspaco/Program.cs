internal class Program
{
    static void ImprimeSemEspaco(string s1)
    {
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != ' ')
            {
                Console.Write("  {0} ", s1[i]);    
            }
        }
    }
    private static void Main(string[] args)
    {
        string s1;

        Console.Write("Digite uma string: ");
        s1 = Console.ReadLine();

        Console.Write("\nImpressão sem os espaços:");

        ImprimeSemEspaco(s1);

        Console.ReadKey();
    }
}
