using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPropriedades.Models
{
  public class Curso
  {
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
      Alunos.Add(aluno);
    }

    public int QuantidadeAlunosMatriculados()
    {
      int quantidade = Alunos.Count; //Método que conta quantos alunos existem dentro da lista
      return quantidade;
    }

    public bool RemoverAlunos(Pessoa aluno)
    {
      return Alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
      Console.WriteLine($"Alunos do curso de: {Nome}");
      for (int i = 0; i < Alunos.Count; i++)
      {
        string texto = $"N° {i + 1} - {Alunos[i].NomeCompleto}";
        Console.WriteLine(texto);
      }
    }

  }
}