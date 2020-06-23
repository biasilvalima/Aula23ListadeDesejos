namespace Aula23ListasObejtos
{
    public class Produto
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public string Cor { get; set; }
        public int Codigo { get; set; }

        public Produto(string _nome, float _preco, string _cor, int _codigo)
        {
            this.Nome = _nome;
            this.Preco = _preco;
            this.Cor = _cor;
            this.Codigo = _codigo;
        }

    }
}