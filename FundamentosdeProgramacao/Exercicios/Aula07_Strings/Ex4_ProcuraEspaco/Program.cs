internal class Program
{
    private static void Main(string[] args)
    {
        string s1;
        int cont = 0;

        Console.Write("Digite uma string: ");
        s1 = Console.ReadLine();

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] == ' ')
            {
                cont++;
            }
        }

        Console.WriteLine("O número de espaços em branco da string '{0}' é {1}.", s1, cont);

        Console.ReadKey();
    }
}
