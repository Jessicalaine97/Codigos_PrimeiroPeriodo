internal class Program
{
    static void ImprimeSoMinusculo(string s1)
    {
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] >= 'a' && s1[i] <= 'z')
            {
                Console.Write("  {0} ", s1[i]);    
            }
            else
            {
                Console.Write("\n  Não há letras minúsculas na string informada!");
                break;                   
            }
        }
    }
    private static void Main(string[] args)
    {
        string s1;

        Console.Write("Digite uma string: ");
        s1 = Console.ReadLine();

        Console.Write("\nImpressão apenas das letras minúsculas:");

        ImprimeSoMinusculo(s1);

        Console.ReadKey();
    }
}
