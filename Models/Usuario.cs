namespace SimuladoIronFit.Api.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }

    public class RegisterDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class LoginDto
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}