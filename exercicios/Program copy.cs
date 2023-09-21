// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o nome do aluno;");
string aluno = Console.ReadLine();
Console.WriteLine("Digite o valor da primeira nota;");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da segunda nota;");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da terceira nota;");
int z = int.Parse(Console.ReadLine());

int soma = x + y + z;
int media = soma / 3;


Console.WriteLine($" A nota foi de {aluno} foi {media}");

if (media < 7){
    Console.WriteLine($"{media} foi abaixo da média");
} else {
    Console.WriteLine($"{media} foi acima da média");
}