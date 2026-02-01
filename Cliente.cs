using System;

public class Cliente : Usuario{
	public string endereco { get; set; }
    public string telefone { get; set; }

    public Cliente (int id, string nome, string email, string senha, string endereco, string telefone)
        : base(id, nome, email, senha){
            this.endereco = endereco;
            this.telefone = telefone;
    }
    public void AbrirChamado() => Console.WriteLine($"{Nome} Abriu um chamado.");
}