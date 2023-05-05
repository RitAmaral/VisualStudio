using ConsoleApp3;

internal class Program
{
    private static void Main(string[] args)
    {
        //Exercício do Banco - melhorado

        ContaBancaria cb;

        Console.WriteLine("Entre com o nº de conta: ");
        int numconta = int.Parse(Console.ReadLine());
        Console.WriteLine("Nome do titular da conta: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Deseja fazer um depósito inicial? S/N");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 'S' || resp == 's')
        {
            Console.WriteLine("Insira o valor do depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine());
            cb = new ContaBancaria(numconta, nome, depositoInicial);
        }
        else { cb = new ContaBancaria(numconta, nome); }

        Console.WriteLine();
        Console.WriteLine("Dados da conta: " + "\n" + cb);
        Console.WriteLine();
        Console.WriteLine("Valor a depositar: ");
        double quantia = double.Parse(Console.ReadLine());
        cb.Deposito(quantia);
        Console.WriteLine("Dados atualizados da conta: ");
        Console.WriteLine(cb);

        Console.WriteLine();
        Console.WriteLine("Que valor pretende levantar? ");
        quantia = double.Parse(Console.ReadLine());
        cb.Levantamento(quantia);
        Console.WriteLine("Dados atualizados da conta: ");
        Console.WriteLine(cb);
        Console.WriteLine("Onde está o guito");
        Console.WriteLine("Quem tem o guito?");
        Console.WriteLine("Quem é o guito?");
        //Se quiser mudar o nome, ou seja, utilizar o set:       
        cb.Nome = "Nicolau e Lucio";
        Console.WriteLine(cb);
    }
}