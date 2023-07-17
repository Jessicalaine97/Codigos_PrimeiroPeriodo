using System;
using System.Text;
internal class Program
{
    const int TAM = 3;
    static void LeInformacoes(Ingresso[] ingressos)
    {  
        for (int i=0; i<ingressos.Length; i++)
        {
            ingressos[i]= new Ingresso();

            Console.WriteLine(" Informe os dados do ingresso {0}/{1}:", i+1, ingressos.Length);

            Console.Write("    Preço {0}/{1}: ", i+1, ingressos.Length);
            ingressos[i].Preco=Convert.ToDouble(Console.ReadLine());

            Console.Write("    Local {0}/{1}: ", i+1, ingressos.Length);
            ingressos[i].Local=Console.ReadLine();

            Console.Write("    Atração {0}/{1}: ", i+1, ingressos.Length);
            ingressos[i].Atracao=Console.ReadLine();
        }
    }
    private static void Main(string[] args)
    {
        Ingresso[] ingressos = new Ingresso[TAM];
        Ingresso maisCaro, maisBarato;

        LeInformacoes(ingressos);
    
        maisBarato =ingressos[0];
        maisCaro=ingressos[0];

        for(int i=0; i<ingressos.Length; i++)
        {
            if (ingressos[i].Preco<maisBarato.Preco)
                maisBarato=ingressos[i];

            if (ingressos[i].Preco>maisCaro.Preco)
                maisCaro=ingressos[i];
        }

        Console.WriteLine("Mais barato: {0}", maisBarato.Atracao);
        Console.WriteLine("Mais caro: {0}", maisCaro.Atracao);

        Console.ReadKey();
    }
}