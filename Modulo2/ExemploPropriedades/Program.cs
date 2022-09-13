using ExemploPropriedades.Models;

// Aula Propriedades, Métodos e Construtores
/* 
Pessoa pessoa1 = new Pessoa(nome: "Giovana", sobrenome: "Macedo");
Pessoa pessoa2 = new Pessoa(nome: "Mateus", sobrenome: "Rocha");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.ListarAlunos(); 
*/

//Aula Exceções e Coleções com C#
/* 
try
{
  string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

  foreach (string linha in linhas)
  {
    Console.WriteLine(linha);
  }
}
catch (DirectoryNotFoundException ex)
{
  Console.WriteLine($"Ocorreu uma exceção de leitura do diretório. {ex.Message}");
}
catch (FileNotFoundException ex)
{
  Console.WriteLine($"Ocorreu uma exceção de leitura do arquivo. {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
} 
*/

//Aula Tuplas, Operador Ternário e Desconstrução de um Objeto com C#
(int id, string nome, string sobrenome) tupla = (1, "Giovana", "Macedo");
ValueTuple<int, string, string> tupla2 = (2, "Mateus", "Rocha");

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");

Console.WriteLine($"ID: {tupla2.Item1}");
Console.WriteLine($"Nome: {tupla2.Item2}");
Console.WriteLine($"Sobrenome: {tupla2.Item3}");