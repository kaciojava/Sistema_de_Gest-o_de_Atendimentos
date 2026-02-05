using System;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_de_Gest_o_de_Atendimentos
{
    // Foca apenas nas regras de negócio e manipulação da lista
    public class ChamadoService
    {
        private List<Chamado> chamados = new List<Chamado>();

        public void RegistrarChamado(Chamado chamado)
        {
            chamados.Add(chamado);
            Console.WriteLine($"Chamado {chamado.Id} registrado com sucesso.");
        }

        // Polimorfismo: o método funciona para qualquer critério de filtro
        public List<Chamado> ListarChamados(Func<Chamado, bool> filtro)
        {
            return chamados.Where(filtro).ToList();
        }

        // Exemplo de uso de Dependency Inversion (dependendo da abstração IAtribuivel)
        public void AlocarTecnico(IAtribuivel item, Tecnico tecnico)
        {
            item.AtribuirTecnico(tecnico);
        }
    }
}