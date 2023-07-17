internal class Program
{
    private static void Main(string[] args)
    {
        int num, i=1, cont=0;

        Console.WriteLine("Digite um número  inteiro e positivo:");
        num = Convert.ToInt32(Console.ReadLine());
        //conferindo se é positivo
        if (num>0)
        {
            while (i <= num)
            {
                if (num % i == 0)
                {
                    cont++;
                }
                i++;
            }
            if (cont == 2)
                Console.WriteLine("O número {0} é primo.", num);
            else
                Console.WriteLine("O número {0} não é primo.", num);
        }
        else
            Console.WriteLine("O valor precisa ser um número positivo!");

    Console.ReadKey();
    }
}