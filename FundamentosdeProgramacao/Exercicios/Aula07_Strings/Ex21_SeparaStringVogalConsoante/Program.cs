using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string s1, sVogais="", sConsoantes="";
        char aux;

        Console.Write("Digite a string: ");
        s1 = Console.ReadLine();

        for (int i=0; i<s1.Length; i++)
        {
            if (s1[i]>='a' && s1[i]<='z' || s1[i]>='A' && s1[i]<='Z')
            {
                if (s1[i]=='a' || s1[i]=='e' || s1[i]=='i'|| s1[i]=='o'|| s1[i]=='u'|| s1[i]=='A'|| s1[i]=='E'|| s1[i]=='I'|| s1[i]=='O'|| s1[i]=='U')
                {
                    sVogais+=s1[i];
                }
                else
                {
                    sConsoantes+=s1[i];
                }
            }
            else
            {
                Console.Write("String contendo caracteres inválidos!");
            }
        }

        Console.Write("\nA String '{0}' apresenta:", s1);

        Console.Write("\n  Vogais: ");

        for  (int i=0; i<sVogais.Length; i++)
        {
            Console.Write("{0}", sVogais[i]);
        }

        Console.Write("\n  Consoantes:");

        for  (int i=0; i<sConsoantes.Length; i++)
        {
            Console.Write("{0}", sConsoantes[i]);
        }

        Console.ReadKey();
    }
}
