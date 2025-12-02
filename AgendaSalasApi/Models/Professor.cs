namespace AgendaSalasApi.Models
{
    public class Professor : Pessoa
    {
        public string Departamento { get; set; }

        public override string GetTipoPessoa()
        {
            return "Professor";
        }
    }
}