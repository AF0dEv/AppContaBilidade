namespace RegistoMovimentosSrJoaquim.Business.Models
{
    internal class Movimento
    {
        // Construtor
        public Movimento(DateTime data, string descricao, int valor, string marcacao, int clienteId)
        {
            this.data = data;
            this.descricao = descricao;
            this.valor = valor;
            this.marcacao = marcacao;
            this.ClienteId = clienteId;
        }

        // Propriedades

        private int id;
        private DateTime data;
        private string descricao;
        private int valor;
        private char tipo;
        private string marcacao;
        private Cliente cliente = null!;


        // Métodos
        public int Id { get; set; }
        

        public DateTime Data { get; set; }

        public string? Descricao { get; set; }
        public int Valor { get; set; }
        public char Tipo { get; set; }

        public string? Marcacao { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

    }
}
