using SimuladoIronFit.Api.Models;

namespace SimuladoIronFit.Api.Models
{
    public class AlunoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int PersonalId { get; set; }
        public string NomePersonal { get; set; }
    }

    public class CriarAlunoDto
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int PersonalId { get; set; }
    }
}