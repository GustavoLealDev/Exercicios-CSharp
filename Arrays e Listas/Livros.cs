using System;

namespace Course
{
     class Livros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoDePublicacao { get; set; }
        public double Preco {  get; set; }

        public Livros(string titulo, string autor, int anoDePublicacao, double preco)
        {
            Titulo = titulo;
            Autor = autor;
            AnoDePublicacao = anoDePublicacao;
            Preco = preco;
        }

        public override string ToString()
        {
            return "Livro : " + Titulo + 
                ", Autor: " + Autor + 
                ", Ano: " + AnoDePublicacao + 
                ", Preço: " + Preco.ToString("F2");
        }
    }
}
