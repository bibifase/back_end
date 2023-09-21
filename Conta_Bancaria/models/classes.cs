using System;

class ContaCorrente
{
    
    public string Titular { get; }
    public double Saldo { get;  set; }

    public ContaCorrente(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo disponível na conta de {Titular} é {Saldo}");
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }
        else
        {
            Console.WriteLine("O valor do saque deve ser maior que zero.");
        }
    }
}

