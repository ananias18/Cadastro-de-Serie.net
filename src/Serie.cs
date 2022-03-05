using System;

namespace APP.Series
{
    public class Serie : EntidadeBase
    {
        // ATRIBUTOS

        private Genero Genero { get; set; }

        private string Título { get; set; }

        private string Descrição { get; set; }

        private int Ano { get; set; }

        private bool Exluido { get; set; }

        public Serie(int Id, Genero genero, string titulo, string descrição, int ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Título = titulo;
            this.Ano = ano;
            this.Exluido = false;
        }
        public override string ToString()
        {
            string retorno = "";

            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Título + Environment.NewLine;
            retorno += "Descrição: " + this.Descrição + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Exluido;
            return retorno;
        }

        public string retornoTítulo()
        {
            return this.Título;
        }

        public bool retornaExcluido()
        {
            return this.Exluido;
        }

        public int retornoId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Exluido = true;
        }
    }
}