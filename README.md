# 🛠️ Sistema de Gestão de Atendimentos (Help Desk)

Este projeto é uma solução de **backend robusta** desenvolvida em **C#**, focada na aplicação prática de **Programação Orientada a Objetos (POO)** e nos princípios **SOLID**. O sistema gerencia o ciclo de vida de chamados de suporte técnico, desde a triagem até a resolução final.

## 👥 Integrantes do Grupo
* **[ERIVELTON KÁCIO]** - [https://github.com/kaciojava]
* **[SANDERSON PEREIRA]** - [https://github.com/Snzada]

---

## 📊 Diagrama de Classes (UML)
O sistema foi modelado para garantir **baixo acoplamento** e **alta coesão**.



---

## 🧠 Conceitos de Orientação a Objetos Aplicados

* **Classes Abstratas:** A classe **`Usuario`** é definida como **abstrata**, servindo como modelo base e impedindo instâncias diretas.
* **Herança:** As classes **`Cliente`** e **`Tecnico`** estendem **`Usuario`**, herdando atributos como `Id` e `Nome`.
* **Interfaces:** Uso das interfaces obrigatórias **`IAtribuivel`** e **`IEncerravel`** para padronizar comportamentos específicos.
* **Composição:** A classe **`Chamado`** possui uma lista de **`HistoricoChamado`**, garantindo a rastreabilidade total do atendimento.
* **Encapsulamento:** Propriedades com **`private set`** protegem o estado interno do objeto contra alterações indevidas.

---

## 💎 Princípios SOLID Implementados

* **[S] - Single Responsibility:** A classe **`Chamado`** armazena dados, enquanto a **`ChamadoService`** gerencia as regras de negócio.
* **[O] - Open/Closed:** O sistema suporta novas categorias ou usuários sem modificar o código existente.
* **[L] - Liskov Substitution:** **`Cliente`** e **`Tecnico`** podem substituir **`Usuario`** em qualquer parte da lógica sem causar erros.
* **[I] - Interface Segregation:** Utilizamos **interfaces granulares** em vez de uma única interface genérica.
* **[D] - Dependency Inversion:** O serviço de chamados depende de **abstrações (interfaces)**, facilitando a manutenção e escalabilidade.

---

## 🚀 Tecnologias e Execução
* **Linguagem:** **C# (.NET 8.0)**.
* **IDE:** **Visual Studio 2022**.

### Como rodar:
1. Clone o repositório.
2. Abra o arquivo **`Sistema_de_Gest_o_de_Atendimentos.sln`**.
3. Execute o projeto (**F5**) para abrir o menu interativo no terminal.