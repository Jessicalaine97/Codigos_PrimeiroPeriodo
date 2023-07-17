internal class Program
{
    private static void Main(string[] args)
    {
        int num, i; 
        double e=0;

        Console.WriteLine("Digite um valor inteiro e positivo:");
        num=Convert.ToInt32(Console.ReadLine());

       for(i=1; i<=num; i++)
       {
        e +=(1/num);
       }

        Console.WriteLine("O resultado da expressão é: {0:N2}.", e+1);

        Console.ReadKey();
    }
}