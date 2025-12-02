namespace AgendaSalasApi.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }

        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        private string _email;
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public virtual string GetTipoPessoa()
        {
            return "Pessoa";
        }
    }
}