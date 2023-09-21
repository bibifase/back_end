public class Program
{
    public static void Main()
    {
        var pessoa1 = new
        {
            nome = "João",
            idade = 20
        };
        var pessoa2 = new
        {
            nome = "Maria",
            idade = 17
        };

       Console.WriteLine("Digite a marca do veículo: ");
        string marca = Console.ReadLine();

        Console.WriteLine("Digite o modelo do veículo: ");
        string modelo = Console.ReadLine();

        Console.WriteLine("Digite o ano do veículo: ");
        string ano = Console.ReadLine();

        var possante = new
        {
            marca,
            modelo,
            ano
        };

        Console.WriteLine($"O carro {modelo} é da marca {marca} e do ano {ano}");
        Console.WriteLine($"A pessoa um se chama {pessoa1.nome} e a segunda se chma {pessoa2.nome}");

    }
}