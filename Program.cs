using System;

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

        }
    }
}
