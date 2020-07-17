using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula27_28_29_30
{
    public class Produto
    {
       
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            //Criando uma pasta CSV
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        /// <summary>
        /// preparador das linhas do CVS
        /// </summary>
        /// <param name="produto"></param>
        /// <returns>Retorna no CSV a linha organizada </returns>
        private string PrepararLinhaCSV(Produto produto){
            return $"codigo={produto.Codigo}-Nome {produto.Nome}-Preço R$ {produto.Preco}";
        }
        /// <summary>
        /// inserir
        /// </summary>
        /// <param name="p">inseri as informaçoes no CVS</param>
        public void Inserir(Produto p){
            var linha = new string[]{p.PrepararLinhaCSV(p)};
            File.AppendAllLines(PATH, linha);
        }
        public List<Produto> Ler(){


        List<Produto> produtos = new List<Produto>();

        string[] linhas = File.ReadAllLines(PATH);

        foreach(var linha in linhas){

            string[] dados = linha.Split(";");

            Produto pro = new Produto();
            pro.Codigo = Int32.Parse(SepararDados(dados[0]));
            pro.Nome = SepararDados(dados[1]);
            pro.Preco = Int32.Parse(SepararDados(dados[2]));

            produtos.Add(pro);
        }
            produtos = produtos.OrderBy(z => z.Nome).ToList();

            return produtos;

        }
        public string SepararDados(string dados)
        {
        
            return dados.Split("=")[1];
        }

        
      }
}