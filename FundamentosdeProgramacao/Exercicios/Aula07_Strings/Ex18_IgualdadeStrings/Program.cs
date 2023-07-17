using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string s1 = "Fundamentos", s2 = "de", s3 = "Programação", s4, s5;

        s4 = s1 + " " + s2 + " " + s3;
        s5 = "Fundamentos de Programação";

        Console.Write("\nIgualdade entre strings:");

        if (s4 == s5)
        {
            Console.Write(" True");
        }
        else
        {
            Console.Write(" False");
        }

        Console.ReadKey();
    }
}
