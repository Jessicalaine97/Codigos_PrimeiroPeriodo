using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string s1, cripto="";
        int k;

        Console.Write("\nDigite uma mensagem: ");
        s1=Console.ReadLine();

        Console.Write("\nDigite um valor: ");
        k=Convert.ToInt32(Console.ReadLine());

        Console.Write("\nMensagem criptografada: ");

        for (int i=0; i<s1.Length; i++)
        {
            cripto+=Convert.ToChar((s1[i])+k);
            Console.Write("{0}", cripto[i]);
        }
       
        Console.ReadKey();
    }
}

