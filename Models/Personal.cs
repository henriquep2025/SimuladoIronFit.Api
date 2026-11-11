using SimuladoIronFit.Api.Models;
using System.Text.Json.Serialization;

namespace SimuladoIronFit.Api.Models
{
    public class Personal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CpfCriptografado { get; set; }
        public int UsuarioId { get; set; }

        [JsonIgnore]
        public Usuario Usuario { get; set; }

        [JsonIgnore]
        public List<Aluno> Alunos { get; set; } 
    }
}

