namespace RegistoMovimentosSrJoaquim.Business.Models
{
    internal class Movimento
    {
        // Construtor
        public Movimento(DateTime data, string descricao, int valor, string marcacao, int clienteId)
        {
            this.Data = data;
            this.Descricao = descricao;
            this.Valor = valor;
            this.Marcacao = marcacao;
            this.ClienteId = clienteId;
        }

        // Métodos
        public int Id { get; set; }
        

        public DateTime Data { get; set; }

        public string? Descricao { get; set; }
        public int Valor { get; set; }
        public char Tipo { get; set; }

        public string? Marcacao { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; } = null!;

    }
}
