using System;
internal class Program
{
    static void Soletrado(string texto)
    {
        for (int i = 0; i < texto.Length; i++)
        {
            if(texto[i]==' ')
            {
                Console.Write("{0}", texto[i]);
            }
            else
            {
                Console.Write("-{0}", texto[i]);
            }
        }
    }
    private static void Main(string[] args)
    {
        string texto = "eu sou a mosca que poucou em sua sopa";

        Console.Write("\nSoletrando: ");

        Soletrado(texto);

        Console.ReadKey();
    }
}
