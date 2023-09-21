class Program
{
    static void Main()
    {
        Console.Write("Informe o nome do titular da conta:");
        string nomeTitular = Console.ReadLine();

        ContaCorrente conta = new ContaCorrente(nomeTitular);

        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("»»————-꧁𓊈𒆜Ⓜⓔⓝⓤ𒆜𓊉꧂————-««");
            Console.WriteLine("1 ★ Consultar saldo");
            Console.WriteLine("2 ★ Depositar");
            Console.WriteLine("3 ★ Sacar");
            Console.WriteLine("0 ★ Sair");
            Console.Write("Selecione uma opção:");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    conta.ConsultarSaldo();
                    break;
                case 2:
                    Console.Write("➫ ✎ Digite o valor que deseja depositar:");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                case 3:
                    Console.Write("➫ ✎ Digite o valor do saque:");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case 0:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("✎ Opção inválida ☹");
                    break;
            }
        }

        Console.WriteLine("➫ Programa encerrado. ㋡ ");
    }
}

