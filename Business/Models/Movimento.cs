namespace RegistoMovimentosSrJoaquim.Business.Models
{
    internal class Movimento
    {
        // Construtor
        public Movimento()
        {

        }

        // Propriedades

        private int id;
        private DateTime data;
        private string descricao;
        private int valor;
        private char tipo;
        private string marcacao;
        private Cliente cliente;


        // Métodos
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public string? Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public char Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public string? Marcacao
        {
            get { return marcacao; }
            set { marcacao = value; }
        }

        public Cliente IdCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
    }
}
