internal class Program
{
    static void ImprimeMaiusculo(string s1)
    {
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] >= 'a' && s1[i] <= 'z')
            {
                Console.Write("  {0} ", Convert.ToChar(s1[i] - 32));
            }
            else
            {
                Console.Write("{0} ", s1[i]);
            }
        }
    }
    private static void Main(string[] args)
    {
        string s1;

        Console.Write("Digite uma string: ");
        s1 = Console.ReadLine();

        Console.Write("\nImpressão das letras em maiúsculo: ");

        ImprimeMaiusculo(s1);

        Console.ReadKey();
    }
}
