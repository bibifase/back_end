public class Program
{
    public static void Main(){
        try{
        Console.WriteLine("Digite aqui um numero inteiro");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Voce digitou o numero {numero}");
    }
    catch (FormatException){
        Console.WriteLine("DIGITE UM NUMEO INTEIRO")
    }
    catch (Exception erro){
        Console.WriteLine($"OCORREU UM ERROR: {erro.Message}");
    }
}

}