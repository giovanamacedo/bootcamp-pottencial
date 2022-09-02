namespace src.Models;

public class Contract
{
  public DateTime DataCriacao { get; set; }
  public string TokenId { get; set; }
  public double Valor { get; set; }

  public bool Pago { get; set; }

  public Contract()
  {
    this.DataCriacao = DateTime.Now;
    this.Valor = 0;
    this.TokenId = "0000";
    this.Pago = false;
  }

  public Contract(double Valor, string TokenId)
  {
    this.DataCriacao = DateTime.Now;
    this.TokenId = TokenId;
    this.Valor = Valor;
    this.Pago = false;
  }
}