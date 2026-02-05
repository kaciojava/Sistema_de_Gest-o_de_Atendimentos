using System;
using System.Collections.Generic;
using System.Linq;
using Sistema_de_Gest_o_de_Atendimentos;

namespace Sistema_de_Gest_o_de_Atendimentos
{
    class Program
    {
        static List<Chamado> listaChamados = new List<Chamado>();
        static ChamadoService service = new ChamadoService();
        static string tipoUsuarioLogado = ""; // "Tecnico" ou "Cliente"

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE SUPORTE TÉCNICO ===");
                Console.WriteLine("1. Entrar como Técnico");
                Console.WriteLine("2. Entrar como Cliente");
                Console.WriteLine("3. Sair");
                Console.Write("\nSelecione o acesso: ");

                string opcao = Console.ReadLine();

                if (opcao == "1") { tipoUsuarioLogado = "Tecnico"; MenuPrincipal(); }
                else if (opcao == "2") { tipoUsuarioLogado = "Cliente"; MenuPrincipal(); }
                else if (opcao == "3") break;
            }
        }

        static void MenuPrincipal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"MODO: {tipoUsuarioLogado.ToUpper()}");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Listar Chamados");
                Console.WriteLine("2. Abrir Novo Chamado (Novo Cliente)");

                // Opção exclusiva para a tela de técnico
                if (tipoUsuarioLogado == "Tecnico")
                {
                    Console.WriteLine("3. Atribuir-se a um Chamado (Novo Tecnico)");
                    Console.WriteLine("4. Finalizar Atendimento");
                }

                Console.WriteLine("0. Voltar/Sair");
                Console.Write("\nComando: ");
                string cmd = Console.ReadLine();

                if (cmd == "1") Listar();
                else if (cmd == "2") CriarChamado();
                else if (cmd == "3" && tipoUsuarioLogado == "Tecnico") AtribuirTecnico();
                else if (cmd == "4" && tipoUsuarioLogado == "Tecnico") EncerrarChamado();
                else if (cmd == "0") break;
            }
        }

        static void CriarChamado()
        {
            Console.Clear();
            Console.WriteLine("-- NOVO CLIENTE E CHAMADO --");

            Console.Write("Nome do Cliente: ");
            string nome = Console.ReadLine() ?? "Empresa X";

            // instanciando Cliente (Exigido pelo seu construtor)
            Cliente cliente = new Cliente(new Random().Next(100, 999), nome, "Rua Exemplo, 123");

            Console.Write("Descrição do problema: ");
            string desc = Console.ReadLine() ?? "Sem descrição";

            Categoria cat = new Categoria("Suporte Geral");

            // criando o Chamado com os 4 parâmetros obrigatórios
            Chamado novo = new Chamado(listaChamados.Count + 1, desc, cliente, cat);

            listaChamados.Add(novo);
            service.RegistrarChamado(novo);

            Console.WriteLine("\nSucesso! Chamado registrado para o cliente " + cliente.Nome);
            Console.ReadKey();
        }

        static void AtribuirTecnico()
        {
            Console.Clear();
            Console.WriteLine("-- ATRIBUIÇÃO DE TÉCNICO --");
            Listar();

            Console.Write("\nID do Chamado: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var cham = listaChamados.Find(x => x.Id == id);
                if (cham != null)
                {
                    Console.Write("Seu nome (Técnico): ");
                    string nomeTec = Console.ReadLine() ?? "Técnico Solicitado";

                    // Instanciando Novo Tecnico
                    Tecnico tec = new Tecnico(new Random().Next(1, 100), nomeTec, "Infraestrutura");

                    // Usando o serviço (Polimorfismo/Interface)
                    service.AlocarTecnico(cham, tec);

                    Console.WriteLine($"\nChamado {id} agora está com o técnico {tec.Nome}");
                }
            }
            Console.ReadKey();
        }

        static void EncerrarChamado()
        {
            Console.Clear();
            Console.Write("ID do chamado para encerrar: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var cham = listaChamados.Find(x => x.Id == id);
                if (cham != null)
                {
                    Console.Write("Motivo do encerramento: ");
                    string motivo = Console.ReadLine() ?? "Concluído";

                    cham.Encerrar(motivo);
                    Console.WriteLine("\nChamado encerrado!");
                }
            }
            Console.ReadKey();
        }

        static void Listar()
        {
            Console.WriteLine("\nID | CLIENTE | DESCRIÇÃO | STATUS");
            foreach (var c in listaChamados)
            {
                Console.WriteLine($"{c.Id} | {c.Cliente.Nome} | {c.Descricao} | {c.Status}");
            }
            if (tipoUsuarioLogado == "Cliente") Console.ReadKey();
        }
    }
}