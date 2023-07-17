//Questão 2
    //Faça um programa que leia numeros inteiros informados pelo usuario enquanto o numero lido for um numero primo. Assim que for lido um numero nao primo, o programa deve imprimir a media dos numeros primos informados e, em seguida, ser finalizado. Porem, se o primeiro numero informado pelo usuario nao for primo, o sistema deve apresentar a mensagem "Nunhum numero primo foi informado" ao inves de imprimir a media. utilize a funcao anterior.

internal class Program
{
    private static void Main(string[] args)
    {
      int num, cont=0;
      double soma=0, media=0;
      bool validador;

      Console.WriteLine("Digite um número:");
      num=Convert.ToInt32(Console.ReadLine());

      validador=LePrimo(num);

      if (validador == false)
      {
        Console.WriteLine("Nunhum número primo foi informado.");
        Console.ReadKey();
      }
      else
      {
        while (LePrimo(num) == true)
        {
          Console.WriteLine("Digite o proximo número:");
          num=Convert.ToInt32(Console.ReadLine());
          soma += num;
          cont++;
        }
        media = soma / cont;

        Console.WriteLine("A média é: {0}.", media);
      }
      Console.ReadKey();
  }

//Questão 1
//Faça uma função que receba um numero inteiro por parametro e retorne true se esse numero for primo ou false caso contrario.

static bool LePrimo (int num)
{
  int cont = 0, i;

  for (i=1; i<=num; i++)
  {
    if(num % i == 0)
    {
      cont++;
    }
  }

  if (cont == 2)
    return true;

  else
    return false;
  }
}

  
   
