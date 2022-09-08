//Aula Arrays
/* int[] arrayInteiro = new int[3]; //Aqui podemos armazenar 3 valores inteiros

arrayInteiro[0] = 72;
arrayInteiro[1] = 64;
arrayInteiro[2] = 30;

int[] copiaArray = new int[arrayInteiro.Length * 2];
Array.Copy(arrayInteiro, copiaArray, arrayInteiro.Length);

//Array.Resize(ref arrayInteiro, arrayInteiro.Length * 2);

Console.WriteLine("Percorrendo o Array com FOR");
for (int i = 0; i < arrayInteiro.Length; i++)
{
  Console.WriteLine($"Posição N° {i} - {arrayInteiro[i]}");
}
 
int contadorForEach = 0;
Console.WriteLine();
Console.WriteLine("Percorrendo o Array com FOREACH");
foreach (int valor in arrayInteiro)
{
  Console.WriteLine($"Posição N° {contadorForEach} - {valor}");
  contadorForEach++;
} 
*/

//Aula Listas
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int i = 0; i < listaString.Count; i++)
{
  Console.WriteLine($"Posição N° {i} - {listaString[i]}");
}