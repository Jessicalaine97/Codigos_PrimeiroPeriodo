internal class Program
{
    static int VerificaCaracter(string cadeia, char procurado)
    {
        int cont = 0;

        for (int i = 0; i < cadeia.Length; i++)
        {
            if (cadeia[i] == procurado)
            {
                cont++;
            }
        }
        return cont;
    }
    private static void Main(string[] args)
    {
        string cadeia;
        char procurado;
        int qdd=0;

        Console.WriteLine("Digite uma string:");
        cadeia = Console.ReadLine();

        Console.WriteLine("Digite o caracter procurado:");
        procurado = Convert.ToChar(Console.ReadLine());

        qdd=VerificaCaracter(cadeia, procurado);

        Console.WriteLine("O caracter '{0}' foi encontrado {1} vezes na string '{2}'!", procurado, qdd, cadeia);

        Console.ReadKey();
    }
}
