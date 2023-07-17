internal class Program
{
    static int ContaVogal(string s1)
    {
        int cont = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] == 'a' || s1[i] == 'A' || s1[i] == 'e' || s1[i] == 'E' || s1[i] == 'i' || s1[i] == 'I' || s1[i] == 'o' || s1[i] == 'O' || s1[i] == 'u' || s1[i] == 'U')
            {
                cont++;
            }
        }
        return cont;
    }
    private static void Main(string[] args)
    {
        string s1;
        int qddVogal = 0;

        Console.Write("Digite uma string: ");
        s1 = Console.ReadLine();

        qddVogal = ContaVogal(s1);

        if (qddVogal > 0)
            Console.WriteLine("A quantidade de vogais da string '{0}' é {1}.", s1, qddVogal);
        else
            Console.WriteLine("A string '{0}' não apresenta vogais.", s1);

        Console.ReadKey();
    }
}
