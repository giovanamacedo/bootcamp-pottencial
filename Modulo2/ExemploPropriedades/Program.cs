using ExemploPropriedades.Models;

Pessoa pessoa1 = new Pessoa(nome: "Giovana", sobrenome: "Macedo");
Pessoa pessoa2 = new Pessoa(nome: "Mateus", sobrenome: "Rocha");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos();