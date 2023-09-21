class ex005{

    public static void Main()
    {
        ListaChurrasco();

    }
            public static void ListaChurrasco(){
        string[] Produtos = new string[6];

        Produtos[0] = "Carne 3kg";
        for (int i = 0; i < Produtos.Length; i++)
        {
            Console.WriteLine("informe o  produto:");
            string produto = Console.ReadLine();
            Produtos[i] = produto;
        }
    Array.Sort(Produtos);

    foreach (string item in Produtos) {
        Console.WriteLine($" item  {item}");
    }

    }
    }


