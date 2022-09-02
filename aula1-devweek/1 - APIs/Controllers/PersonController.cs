using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
  [HttpGet]
  public Person Get()
  {
    Person pessoa = new Person("Giovana", 19, "000.000.000-00");
    Contract newContract = new Contract(50.00, "abc123");
    pessoa.contracts.Add(newContract);
    return pessoa;
  }

  [HttpPost]
  public Person Post(Person person)
  {
    return person;
  }

  [HttpPut("{id}")]
  public string Update([FromRoute] int id, [FromBody] Person person)
  {
    return "Dados do ID: " + id + " atualizados";
  }

  [HttpDelete("{id}")]
  public string Delete([FromRoute] int id)
  {
    return "Deletado pessoa de ID " + id;
  }
}