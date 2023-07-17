using System;
internal class Program
{
    static void ImprimeInvertida(string texto)
    {
        for (int i = texto.Length-1; i < texto.Length; i--)
        {
            Console.Write("{0}", texto[i]);
        }
    }
    private static void Main(string[] args)
    {
        string texto = "aleluia aleluia";

        Console.Write("\nString Invertida: ");

       ImprimeInvertida(texto);

        Console.ReadKey();
    }
}
