internal class Program
{
    private static void Main(string[] args)
    {
        string frase;
        int i=0, quant;

        Console.WriteLine("Digite a quantidade de repetições:");
        quant = Convert.ToInt32(Console.ReadLine());

        if (quant <= 0)
            Console.WriteLine("Quantidade de repetições inválidas!");
        else
        {
            Console.WriteLine("Digite a frase desejada:");
            frase = Console.ReadLine();

            while (i < quant)
            {
            Console.WriteLine(frase);
            i=i+1;
            }
        }
        Console.ReadKey();
    }
}