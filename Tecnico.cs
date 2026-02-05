namespace Sistema_de_Gest_o_de_Atendimentos
{
    public class Tecnico : Usuario
    {
        public string Especialidade { get; set; }

        public Tecnico(int id, string nome, string especialidade) : base(id, nome)
        {
            Especialidade = especialidade;
        }
    }
}