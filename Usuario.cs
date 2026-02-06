using System;
// Classe "MÃE"
namespace Sistema_de_Gest_o_de_Atendimentos
{
    // Abstração
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        protected Usuario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
