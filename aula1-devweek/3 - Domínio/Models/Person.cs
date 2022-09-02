namespace src.Models;

public class Person
{
  public int Id { get; set; }
  public string Nome { get; set; }
  public int Idade { get; set; }
  public string? Cpf { get; set; }
  public bool CadastroAtividado { get; set; }

  public List<Contract> contracts { get; set; }

  public Person()
  {
    this.Nome = "template";
    this.Idade = 0;
    this.contracts = new List<Contract>();
    this.CadastroAtividado = true;
  }

  public Person(string nome, int idade, string cpf)
  {
    this.Nome = nome;
    this.Idade = idade;
    this.Cpf = cpf;
    this.contracts = new List<Contract>();
    this.CadastroAtividado = true;
  }
}
