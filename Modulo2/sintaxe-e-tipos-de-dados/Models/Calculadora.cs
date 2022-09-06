namespace sintaxe_e_tipos_de_dados.Models
{
  public class Calculadora
  {
    public void Soma(int x, int y)
    {
      Console.WriteLine($"{x} + {y} = {x + y}");
    }

    public void Subtracao(int x, int y)
    {
      Console.WriteLine($"{x} - {y} = {x - y}");
    }

    public void Divisao(int x, int y)
    {
      Console.WriteLine($"{x} / {y} = {x / y}");
    }

    public void Multiplicacao(int x, int y)
    {
      Console.WriteLine($"{x} * {y} = {x * y}");
    }

    public void Potencia(int x, int y)
    {
      double pot = Math.Pow(x, y);
      Console.WriteLine($"{x} ^ {y} = {pot}");
    }

    public void Seno(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double seno = Math.Sin(radiano);
      Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
    }

    public void Coseno(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double coseno = Math.Cos(radiano);
      Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(coseno, 4)}");
    }

    public void Tangente(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double tangente = Math.Cos(radiano);
      Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
    }

    public void RaizQuadrada(double x)
    {
      double raiz = Math.Sqrt(x);
      Console.WriteLine($"Raíz quadrada de {x} = {Math.Round(raiz, 4)}");
    }
  }
}