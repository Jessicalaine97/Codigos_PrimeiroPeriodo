using System;
internal class Program
{
    static int RetornaNovaString(string s1, char caractere)
    {
        string novaString="";
        int cont=0;

        for (int i=0; i<s1.Length; i++)
        {
            if(s1[i]==caractere)
            {
                novaString+=s1[i];
                cont++;
            }
        }
        Console.Write("\n  Nova string: {0}", novaString);

        return cont;

    }
    private static void Main(string[] args)
    {
        string s1="jessica";
        char caractere='a';
        int result=0;

        Console.Write("\nString informada: {0}", s1);
        Console.Write("\nCaractere informado: {0}", caractere);

        result=RetornaNovaString(s1, caractere);

        Console.Write("\n    Número de remoções da string: {0}", result);
        
        Console.ReadKey();
    }
}
