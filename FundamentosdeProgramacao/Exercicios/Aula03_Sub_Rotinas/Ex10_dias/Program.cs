internal class Program
{
    private static void Main(string[] args)
    {
        int ano, mes, dia, idadeDia;

        Console.WriteLine("Serão feitas 3 perguntas acerca da sua idade em anos, meses e dias, responda cada uma separadamente por gentileza :)");
        Console.WriteLine("Qual a idade em anos que você tem?");
        ano=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("E quantos meses você tem?");
        mes=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("E dias?");
        dia=Convert.ToInt32(Console.ReadLine());

        idadeDia=ConverteIdade (ano, mes, dia);
        Console.WriteLine("Sua idade de {0} ano(s), {1} mês(s) e {2} dia(s) equivale a {3} dia(s).", ano, mes, dia, idadeDia);
        Console.ReadKey();
    }
    static int ConverteIdade (int ano, int mes, int dia)
    {
        int idadeEmAnos, idadeEmMeses, idadeEmDias;

        idadeEmAnos=ano*365;
        idadeEmMeses=mes*30;
        idadeEmDias=dia;
        idadeEmDias=idadeEmAnos+idadeEmMeses+idadeEmDias;
        return idadeEmDias;
    }
}