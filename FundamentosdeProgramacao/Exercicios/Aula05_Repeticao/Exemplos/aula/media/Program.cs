internal class Program
{
    private static void Main(string[] args)
    {
        int num, i, cont=0;
        double soma=0, media=0; 

        Console.WriteLine("Digite um número inteiro:");
        num=Convert.ToInt32(Console.ReadLine());
        
        while (num != 0)
        {
            for(i=0; i<=num; i++)
            {
                if(num % 2 == 0)
                {
                    soma += num;
                    cont++;
                }
                Console.WriteLine("Digite o próximo número inteiro:");
                num=Convert.ToInt32(Console.ReadLine());
            }
        }
        media=soma/cont;

        Console.WriteLine("A média dos valores é: {0:N2}.", media);
        Console.ReadKey();
    }
}