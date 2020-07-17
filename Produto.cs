using System.IO;

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
        private string PrepararLinhaCSV(Produto produto){
            return $"codigo={produto.Codigo}-Nome {produto.Nome}-Preço R$ {produto.Preco}";
        }
        public void Inserir(Produto p){
            var linha = new string[]{p.PrepararLinhaCSV(p)};
            File.AppendAllLines(PATH, linha);
        }
  
    }
}