using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Codigo= 1;
            produto.Nome = "Air force";
            produto.Preco = 399.99f;

            produto.Inserir(produto);

            List<Produto> lista = new List<Produto>();
            lista = produto.Ler();

            foreach(Produto item in lista){
                Console.WriteLine($"R${item.Preco} - Nome{item.Nome}");
            }

        }
    }
}
