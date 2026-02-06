using System.Collections.Generic;

namespace Sistema_de_Gest_o_de_Atendimentos
{
    // Esta classe Apenas armazena dados e gere seu próprio estado interno
    public class Chamado : IAtribuivel, IEncerravel
    {
        public int Id { get; private set; }
        public string Descricao { get; set; }
        public string Status { get; private set; }
        public Categoria Categoria { get; set; }
        public Cliente Cliente { get; set; }
        public Tecnico? TecnicoResponsavel { get; private set; }

        // encapsulamento: a lista não pode ser modificada diretamente de fora
        private List<HistoricoChamado> _historico = new List<HistoricoChamado>();
        public List<HistoricoChamado> Historico => _historico;

        public Chamado(int id, string descricao, Cliente cliente, Categoria categoria)
        {
            Id = id;
            Descricao = descricao;
            Cliente = cliente;
            Categoria = categoria;
            Status = "Aberto";
            _historico.Add(new HistoricoChamado("Chamado criado."));
        }

        // Implementação de IAtribuivel
        public void AtribuirTecnico(Tecnico tecnico)
        {
            TecnicoResponsavel = tecnico;
            Status = "Em Andamento";
            _historico.Add(new HistoricoChamado($"Técnico {tecnico.Nome} atribuído."));
        }

        // Implementação de IEncerravel
        public void Encerrar(string motivo)
        {
            Status = "Encerrado";
            _historico.Add(new HistoricoChamado($"Encerrado. Motivo: {motivo}"));
        }
    }
}
//xd:D