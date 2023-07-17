internal class Program
{
    static bool VerificaString(string s1, string s2)
    {
        int cont = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i]==s2[0])
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i]==s2[j])
                    {
                        cont++;
                        i++;
                    } 
                }
            }
        }
        if (cont == s2.Length)
            return true;
        else
            return false;
    }
    private static void Main(string[] args)
    {
        string s1, s2;
        bool resultado;

        Console.Write("\nDigite a primeira string: ");
        s1 = Console.ReadLine();

        Console.Write("\nDigite a segunda string: ");
        s2 = Console.ReadLine();

        resultado = VerificaString(s1, s2);

        if (resultado == true)
            Console.WriteLine("\nA string '{0}' foi encontrada na string '{1}'!", s2, s1);
        else
            Console.WriteLine("\nA string '{0}' não foi encontrada na string '{1}'!", s2, s1);

        Console.ReadKey();
    }
}
