internal class Program
{
    static int ContaEspaco(string s1)
    {
        int cont = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] == ' ')
            {
                cont++;
            }
        }
        return cont;
    }
    private static void Main(string[] args)
    {
        string s1;
        int qddEspaco = 0;

        Console.Write("Digite uma string: ");
        s1 = Console.ReadLine();

        qddEspaco = ContaEspaco(s1);

        Console.WriteLine("O número de espaços em branco da string '{0}' é {1}.", s1, qddEspaco);

        Console.ReadKey();
    }
}
