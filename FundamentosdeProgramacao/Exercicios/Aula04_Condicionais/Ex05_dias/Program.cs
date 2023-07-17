internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Digite o número do dia da semana:");
        num=Convert.ToInt32(Console.ReadLine());

        if(num==1)
            Console.WriteLine("Domingo!");
        else if(num==2)
            Console.WriteLine("Segunda!");
        else if(num==3)
            Console.WriteLine("Terça!");
        else if(num==4)
            Console.WriteLine("Quarta!");
        else if(num==5)
            Console.WriteLine("Quinta!");
        else if(num==6)
            Console.WriteLine("Sexta!");
        else if(num==7)
            Console.WriteLine("Sábado!");
        else
            Console.WriteLine("Dia da semana inválido.");

        Console.ReadKey();
    }
}