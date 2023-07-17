internal class Program
{
    static void Estatistica(string texto)
    {
        int contVogal=0, contConsoante=0, ContOutro=0;

        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] >= 65 && texto[i] <= 90 || texto[i] >= 97 && texto[i] <= 122)
            {
                if (texto[i]=='a' || texto[i]=='e' ||texto[i]=='i' ||texto[i]=='o' ||texto[i]=='u' ||texto[i]=='A' ||texto[i]=='E' ||texto[i]=='I' ||texto[i]=='O' ||texto[i]=='U')
                {
                    contVogal++;
                }
                else
                {
                    contConsoante++;
                }
            }
            else
            {
                ContOutro++;
            }
        }
        Console.Write("\n {0}         | Vogais ", contVogal);
        Console.Write("\n {0}         | Consoantes", contConsoante);
        Console.Write("\n {0}         | Outros caracteres", ContOutro);
    }
    private static void Main(string[] args)
    {
        string texto;

        Console.Write("Digite uma string: ");
        texto = Console.ReadLine();

        Console.Write("\nEstatística da String:");
        Console.Write("\nPorcentagem  | Elemento");

        Estatistica(texto);

        Console.ReadKey();
    }
}
