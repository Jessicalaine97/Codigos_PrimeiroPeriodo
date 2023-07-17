internal class Program
{
    static void ImprimePrimeiraMaiusculo(string s1)
    {
        int indice = 0;

        Console.Write("{0}", Convert.ToChar(s1[0] - 32));

        for (int i = 1; i < s1.Length; i++)
        {
            if (s1[i] >= 'a' && s1[i] <= 'z')
            {
                Console.Write("{0}", s1[i]);
            }
            else if (s1[i] == ' ')
            {
                indice = i + 1;
                Console.Write(" {0}", Convert.ToChar(s1[indice] - 32));
                i++;
            }
        }
    }
    private static void Main(string[] args)
    {
        string s1 = "jessica laine";

        Console.Write("\nImpressão com as primeiras letras em maiúsculo: ");

        ImprimePrimeiraMaiusculo(s1);

        Console.ReadKey();
    }
}
