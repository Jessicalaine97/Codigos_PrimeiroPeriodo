using System;
internal class Program
{
    static int Retorna(string texto, char caractere)
    {
        int indice=0;

        for (int i=0; i<texto.Length; i++)
        {
            if (texto[i]==caractere)
            {
                indice=i;
                break;
            }
            else
            {
                indice=-1;
            }
        }
    return indice;
    }
    private static void Main(string[] args)
    {
        string texto = "jessica";
        char caractere = 'k';

        Console.Write("\nResultado: {0}", Retorna(texto, caractere));

        Console.ReadKey();
    }
}
