using SimuladoIronFit.Api.Models;

namespace SimuladoIronFit.Api.Models
{
    public class TreinoAgendadoDto
    {
        public int Id { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Descricao { get; set; }
        public int AlunoId { get; set; }
        public string NomeAluno { get; set; }
        public string NomePersonal { get; set; }
    }

    public class CriarTreinoAgendadoDto
    {
        public DateTime DataAgendamento { get; set; }
        public string Descricao { get; set; }
        public int AlunoId { get; set; }
    }
}
