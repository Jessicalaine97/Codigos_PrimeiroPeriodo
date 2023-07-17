internal class Program
{
    private static void Main(string[] args)
    {
        int num, i = 3, fn = 0, f1 = 1, f2 = 1;

        Console.WriteLine("Quantos termos gostaria de mostrar na série de Fibonacci? ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num == 0 || num < 0)
            Console.WriteLine("A quantidade de termos precisa ser um número positivo!");

        for (i = 1; i <= num; i++)
        {
            if (num == 1)
            {
                Console.WriteLine("F1 = 1.");
            }
            else if (num == 2)
            {
                Console.WriteLine("F2 = 1.");
            }
            else
            {
                fn = f1 + f2 + i;
                Console.WriteLine("F{0} = {1}.", i, fn);
            }
        }
        Console.ReadKey();
    }
}