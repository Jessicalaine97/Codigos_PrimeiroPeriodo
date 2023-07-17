using System;
internal class Program
{
    static bool Palindrome(string s1)
    {
        int cont = 0;

        for (int i = 0, j=s1.Length-1; i < s1.Length; i++, j--)
        {
            if (s1[i] == s1[j])
            {
                cont++;
            }
        }

        if (cont == s1.Length)
            return true;
        else
            return false;
    }
    private static void Main(string[] args)
    {
        string s1 = "asa";
        bool resultado;

        resultado = Palindrome(s1);

        if (resultado == true)
            Console.WriteLine("A string informada é um palíndromo!");
        else
            Console.WriteLine("A string informada não é um palíndromo!");

        Console.ReadKey();
    }
}

