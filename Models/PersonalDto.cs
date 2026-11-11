using SimuladoIronFit.Api.Models;

namespace SimuladoIronFit.Api.Models
{
    public class PersonalDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string EmailUsuario { get; set; }
    }

    public class CriarPersonalDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int UsuarioId { get; set; }
    }
}

    