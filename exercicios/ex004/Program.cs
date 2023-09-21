class DobroMetade
{
    public static void Main()
    {
        int resultadoDobro = Dobrar(3);
        int resultadoMetade = Dividir(8);
        Console.WriteLine(resultadoDobro);
        Console.WriteLine(resultadoMetade);
        TabuadaComWhile();
        Console.WriteLine(Somar (8, 8));
    }

    public static int Dobrar(int n1)
    {
        int dobro = n1 * 2;
        return(dobro);
    }


    public static int Dividir(int n2)
    {
      int metade = n2 / 2;
      return(metade);
    }

public static void TabuadaComWhile(){
        Console.WriteLine("Digite o numero:");
        int num = int.Parse(Console.ReadLine());
        int x = 1;
        do {
            Console.WriteLine($"{num} x {x} = {num*x}");
            x++;
        }
        while (x <= 10);
}


public static int Somar (int n1, int n2)
{
    int soma = n1 + n2;
    return soma;
}

public static void SomaComDoWhile ()
{
    int maior = 0;
    int menor = 10;
    int soma = 0;
    int num = 0;

    do {
        Console.WriteLine("informe um numero positivo, negativo para encerrar");
        num = int.Parse(Console.ReadLine());

        if (num > maior)
                maior = num;

            if (num < menor && num > 0)
                menor = num;

            if (num > 0)
                soma = soma + num;
        } while (num > 0);
        Console.WriteLine($"Menor nº {menor} - maior nº {maior} - soma dos nº {soma}");
    }
    

}