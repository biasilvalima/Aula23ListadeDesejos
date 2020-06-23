namespace Aula23ListasObejtos
{
    public class Cartao
    {
        public string NomeTitular { get; set; }
        public int Numero { get; set; }
        public int CVV { get; set; }

        public Cartao(string _nomeTitular, int _cvv)
        {
            this.NomeTitular = _nomeTitular;
            this.CVV = _cvv;
        }

    }
}