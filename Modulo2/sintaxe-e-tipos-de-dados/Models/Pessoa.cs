namespace sintaxe_e_tipos_de_dados.Models
{
  public class Pessoa
  {
    public String Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {

      //AULA SINTAXE E TIPOS DE DADOS
      //Console.WriteLine($"Olá meu nomé é {Nome}, e tenho {Idade} anos.");

      //AULA TIPOS DE OPERADORES
      /* int a = 10;
      int b = 10;
      int c = a + b;
      c += 5;
      Console.WriteLine(c); */

      /*    //CASTING PARA INT
            //int a = Convert.ToInt32("5"); //Maneira 1
            int a = int.Parse("5"); //Maneira 2
            Console.WriteLine(a); */

      /*       //CASTING PARA STRING
            int inteiro = 5;
            string b = inteiro.ToString();
            Console.WriteLine(b); */

      int quantidadeEstoque = 3;
      int quantidadeCompra = 4;
      bool possivelVenda = quantidadeEstoque >= quantidadeCompra;

      Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
      Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
      Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

      if (possivelVenda)
      {
        Console.WriteLine("Venda realizada");
      }
      else
      {
        Console.Write("Desculpe, não podemos realizar a venda");
      }
    }
  }
}