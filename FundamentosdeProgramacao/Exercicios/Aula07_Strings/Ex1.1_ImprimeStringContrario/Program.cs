internal class Program
{
    private static void Main(string[] args)
    {
        string s1;

        Console.Write("Digite uma string: ");
        s1 = Console.ReadLine();

        Console.Write("\nImpressão ao contrário:");

        for (int i = s1.Length - 1; i <= s1.Length; i--)
        {
            Console.Write("{0}", s1[i]);
        }

        Console.ReadKey();
    }
}
