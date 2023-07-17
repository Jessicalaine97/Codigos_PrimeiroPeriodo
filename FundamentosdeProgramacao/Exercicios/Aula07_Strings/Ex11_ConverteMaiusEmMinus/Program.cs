internal class Program
{
    static char ConverteMaiusMinus(char caractere)
    {
        if (caractere >= 'a' && caractere <= 'z')
        {
            //maiscula: +32
            Console.Write(" {0} ", Convert.ToChar(caractere - 32));
        }
        else
        {
            Console.Write(" Caractere inválido!");
        }
        return caractere;
    }
    private static void Main(string[] args)
    {
        char caractere;
        char caractereConvertido;

        Console.Write("Digite um caractere: ");
        caractere = Convert.ToChar(Console.ReadLine());

        Console.Write("\nImpressão do caractere convertido em maiúscula:");

        caractereConvertido = ConverteMaiusMinus(caractere);

        Console.ReadKey();
    }
}
