internal class Program
{
    private static void Main(string[] args)
    {
        double num, maior, menor;
        int i;

        Console.WriteLine("Digite o primeiro valor: ");
        num=Convert.ToDouble(Console.ReadLine());

        maior=num;
        menor=num;

        for(i=1; i<10 ;i++)
        {
            Console.WriteLine("Digite o próximo valor: ");
            num=Convert.ToDouble(Console.ReadLine());
            
            if (num>maior)
            {
                maior=num;
            }
            else if (num<menor)
            {
                menor=num;
            }
        }

    Console.WriteLine("Entre os 10 números digitados, o maior é {0} e o menor é {1}.", maior, menor);

    Console.ReadKey();
        }
    }