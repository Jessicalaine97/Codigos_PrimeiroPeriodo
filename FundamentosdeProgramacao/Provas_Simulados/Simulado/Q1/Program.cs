internal class Program
{
    //Questão 2
        //Leia a variável qtdeNumeros. Para isso, apresente ao usuário a mensagem 
        //"Informe a quantidade de números positivos a serem lidos: " e, assim que informado, 
        //se qtdeNumeros for zero ou negativo, apresente a mensagem "Quantidade de números 
        //inválida!". Caso contrário, execute o código da questão 3.
    private static void Main(string[] args)
    {
        int qtdeNumeros; //questao 2
        int n, i, maior=0; //questao 3

        Console.WriteLine("Informe a quantidade de números positivos a serem lidos:");
        qtdeNumeros=Convert.ToInt32(Console.ReadLine());

        if (qtdeNumeros <= 0)
            Console.WriteLine("Quantidade de números inválida!");
        else 
        {
    //Questão 3:
        //Nesta questão chamaremos de N o valor armazenado na variável qtdeNumeros.
        //Para esta questão, leia N números positivos informados pelo usuário. Ao término,
        //da leitura, informe qual o maior número lido. Observação: note que precisamos 
        //ler números positivos e que você deve fazer as N leituras chamando a função criada 
        //na questão 1 para garantir que o número lido é positivo.
            
        Console.WriteLine("Informe o primeiro valor:");
        n=Convert.ToInt32(Console.ReadLine());

        maior = n;

        for (i = 2; i <= qtdeNumeros ; i++)
        {
            n = LePositivo();

            if (n > maior)
            {
                maior = n;
            }
        }

            Console.WriteLine("O maior valor lido foi {0}.", maior);

        }

        Console.ReadKey();
    }
    //Questão 1
        //Faça uma função que leia números inteiros informados pelo usuário enquanto não for 
        //lido um número positivo. Assim que for lido um número positivo, a função deve
        //retornar este número. Observação: esta função não recebe parâmetros.
    static int LePositivo()
    {
        int num;

        Console.WriteLine("Digite o próximo número:");
        num = Convert.ToInt32(Console.ReadLine());

        while (num <=0)
        {
            Console.WriteLine("Digite o próximo número:");
            num = Convert.ToInt32(Console.ReadLine());
        }

        return num;
    }
}