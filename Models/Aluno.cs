using System.Text.Json.Serialization;

namespace SimuladoIronFit.Api.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int PersonalId { get; set; } // Vinculo obrigatório

        [JsonIgnore]
        public Personal Personal { get; set; }
    }
}
