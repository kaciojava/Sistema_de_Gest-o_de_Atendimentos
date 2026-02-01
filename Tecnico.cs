using System;

public class Tecnico : Usuario{
	public string Especialidade { get; set; }
	public string Registro { get; set; }
    public Tecnico (int id, string nome, string email, string senha, string especialidade)
		: base(id, nome, email, senha){
			this.Especialidade = especialidade;
	}

}