using System.Collections.Generic;
using Sesi.models;

public class Program
{
    public static void Main()
    {
     //criando uma lista de numeros inteiros
     List<string> listaNomes = new List<string>();
     listaNomes.Add("maria clara"); //posição 0
     listaNomes.Add("beatriz");
     listaNomes.Add("debora");
     Console.WriteLine($"{listaNomes}");
     Console.WriteLine($"neste momento temos {listaNomes.Count} nrs");
      foreach (string x in listaNomes) 
    {
        Console.WriteLine(x);
    }

     Console.WriteLine("-------------------------------");
     

     List<int> listaNumeros = new List<int>();
     listaNumeros.Add(10); //posição 0
     listaNumeros.Add(3);
     listaNumeros.Add(4);

     
     //acessando os dados da lista
     Console.WriteLine(listaNumeros[1]);

     listaNumeros.Add(80);
     Console.WriteLine($"neste momento temos {listaNumeros.Count} nrs");

     Console.WriteLine("-------------------------------");
    
    List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8,9};
    numeros.Add(10);
    //mostrando todos os itens da lista
    foreach (int item in numeros) 
    {
        Console.WriteLine(item);
    }

    numeros.Remove(2); //remover um item da lista
    numeros.RemoveRange(2, 2); //remove o elemento e os outros 2 proximos


    List<Aluno> listaAlunos = new List<Aluno>();
    Aluno novoAluno = new Aluno ("marcos", 15);
    listaAlunos.Add(novoAluno);
    listaAlunos.Add(new Aluno("cesar", 17));
    listaAlunos.Add(new Aluno("raquel", 19));

    Console.WriteLine("Lista de Alunos:");
    foreach (Aluno y in listaAlunos) 
    {
        Console.WriteLine($"nome aluno: {y.nome}");
    }

    listaAlunos.Add(new Aluno("alice", 12));
    listaAlunos.Add(new Aluno("carlos", 15));

    Console.WriteLine("Lista alunos");
    foreach (Aluno item in listaAlunos)
    {
        Console.WriteLine($"nome do alunos: {item.nome} idade {item.idade}");
    }

    var consulta = from aluno in listaAlunos
                   where aluno.idade > 18
                   orderby aluno.nome
                   select aluno;
    Console.WriteLine("Lista de alunos maiores de 18 anos");
    foreach (var item in consulta)
    {
        Console.WriteLine($"nome do alunos: {item.nome} idade {item.idade}");
    }
    var metodo = listaAlunos
                        .Where(aluno => aluno.idade < 18)
                        .OrderBy(aluno => aluno.nome);
    Console.WriteLine("Lista de alunos menores de 18 anos");
    foreach (var item in metodo)
    {
        Console.WriteLine($"nome do alunos: {item.nome} idade {item.idade}");
    }

    }
}
