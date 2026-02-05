using System;

namespace Sistema_de_Gest_o_de_Atendimentos
{
    public class HistoricoChamado
    {
        public DateTime DataRegistro { get; private set; }
        public string Mensagem { get; private set; }

        public HistoricoChamado(string mensagem)
        {
            DataRegistro = DateTime.Now;
            Mensagem = mensagem;
        }

        public override string ToString() => $"[{DataRegistro}] {Mensagem}";
    }
}
