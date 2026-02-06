# 🛠️ Sistema de Gestão de Atendimentos (Help Desk)

Este projeto é uma solução de **backend robusta** desenvolvida em **C#**, focada na aplicação prática de **Programação Orientada a Objetos (POO)** e nos princípios **SOLID**. O sistema gerencia o ciclo de vida de chamados de suporte técnico, desde a triagem até a resolução final.

## 👥 Integrantes do Grupo
* **[ERIVELTON KÁCIO]** - [https://github.com/kaciojava]
* **[SANDERSON PEREIRA]** - [https://github.com/Snzada]


---

## 📊 Diagrama de Classes (UML)
O diagrama abaixo reflete a arquitetura do sistema, destacando o uso de serviços e interfaces para desacoplamento.

![Diagrama UML](<img width="803" height="878" alt="Diagrama Sistema de Atendimentos drawio" src="https://github.com/user-attachments/assets/1bfa45fb-be97-412d-88f0-f8e3b0dd940f" />)

---

## 💎 Aplicação dos Princípios SOLID

* **[S] Single Responsibility:** A classe **`Chamado`** armazena dados e histórico, enquanto a **`ChamadoService`** isola as regras de negócio e manipulação de listas.
* **[O] Open/Closed:** Novas categorias ou tipos de usuários podem ser adicionados via herança sem modificar o funcionamento do `ChamadoService`.
* **[L] Liskov Substitution:** As classes **`Cliente`** e **`Tecnico`** herdam de **`Usuario`** e podem ser utilizadas em qualquer lugar que a classe base seja esperada.
* **[I] Interface Segregation:** Dividimos as ações em interfaces específicas: **`IAtribuivel`** para designação de técnicos e **`IEncerravel`** para conclusão de chamados.
* **[D] Dependency Inversion:** O método `AlocarTecnico` do serviço depende da interface **`IAtribuivel`**, não de uma implementação concreta, garantindo flexibilidade ao código.

---

## 🧠 Conceitos de OO Utilizados
* **Classe Abstrata:** `Usuario` define o contrato base para todos os perfis do sistema.
* **Composição:** `Chamado` contém uma lista de `HistoricoChamado`, que é destruída junto com o objeto principal.
* **Encapsulamento:** Uso de modificadores `private set` para garantir a integridade do `Status` do chamado.

---

## 🚀 Tecnologias e Execução
* **Linguagem:** **C# (.NET 8.0)**.
* **IDE:** **Visual Studio 2026**.

### Como rodar:
1. Clone o repositório.
2. Abra o arquivo **`Sistema_de_Gest_o_de_Atendimentos.sln`**.
3. Execute o projeto (**F5**) para abrir o menu interativo no terminal.
