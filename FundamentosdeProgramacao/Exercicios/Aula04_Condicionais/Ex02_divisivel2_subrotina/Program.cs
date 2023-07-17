internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        bool par;

        Console.WriteLine("Digite um número:");
        num = Convert.ToInt32(Console.ReadLine());

        par = VerificaPar(num);
        if (par == true)
            Console.WriteLine("O número {0} é divisível por 2!", num);
        else
            Console.WriteLine("O número {0} não é divisível por 2!", num);

        Console.ReadKey();
    }
    static bool VerificaPar(int num)
    {
        return num % 2 == 0;
    }
    static bool VerificaImPar(int num)
    {
        return !VerificaPar(num);
    }
}