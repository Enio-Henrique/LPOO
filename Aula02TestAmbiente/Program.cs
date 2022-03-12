using System;
using Aula02TestAmbiente.Entities;

namespace Aula02TeteAmbiente  // pacotes / packpage 
{
    class Program // classe
    {
        static void Main(string[] args)
        {
            // use o control + . para pegar as referencias(imports) dos pacotes
            Console.WriteLine("Hello World!");


            Livro objLivro = new Livro(100, "Banco de dsdos");
            Console.WriteLine(objLivro.GetId() + " - " + objLivro.GetTitulo());

            objLivro.SetValor(199);
            Console.WriteLine("Valor do livro" + objLivro.GetValor());
        }
    }
}
