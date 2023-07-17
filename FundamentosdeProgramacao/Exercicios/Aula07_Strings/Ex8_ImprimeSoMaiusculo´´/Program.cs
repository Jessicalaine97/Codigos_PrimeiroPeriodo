internal class Program
{
    static void ImprimeSoMaiusculo(string s1)
    {
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] >= 'A' && s1[i] <= 'Z')
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

        Console.Write("\nImpressão apenas das letras maiúsculas:");

        ImprimeSoMaiusculo(s1);

        Console.ReadKey();
    }
}
