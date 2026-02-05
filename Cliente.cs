using System;

namespace Sistema_de_Gest_o_de_Atendimentos
{
    public class Cliente : Usuario
    {
        public string Endereco { get; set; }

        public Cliente(int id, string nome, string endereco) : base(id, nome)
        {
            Endereco = endereco;
        }
    }
}