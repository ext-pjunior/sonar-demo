namespace SonarDemo.MVC.Models
{
    public class Cliente
    {
        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
    }
}