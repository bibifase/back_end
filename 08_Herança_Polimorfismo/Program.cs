+using Sesi.Models;
class Program {
    public static void Main(){
        Gato meuGato = new Gato();
        meuGato.nome = "flora";
        meuGato.cor = "laranja";
        meuGato.idade = 2;
        meuGato.especie = "siames";
        meuGato.genero = "feminino";
        meuGato.peso = "6kg";

        Peixe meuPeixe = new Peixe();
        meuPeixe.especie = "baiacu";
        meuPeixe.cor = "marrom";
        meuPeixe.tamanho = "50cm";
        meuPeixe.peso = "100g";
    }
}