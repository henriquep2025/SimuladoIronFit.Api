using System.Text.Json.Serialization;

namespace SimuladoIronFit.Api.Models
{
    public class TreinoAgendado
    {
        public int Id { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Descricao { get; set; }
        public int AlunoId { get; set; }
        public int PersonalId { get; set; }

        [JsonIgnore]
        public Aluno Aluno { get; set; }

        [JsonIgnore]
        public Personal Personal { get; set; }
    }
}
