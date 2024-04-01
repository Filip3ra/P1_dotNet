

/* Questão 1 a)

int i = 1;
switch (i)
{
  case 1:
    break;
  case 2: Console.WriteLine("Um"); break;
  default:
    Console.WriteLine("Outro");
    break;
}
*/

/* Questão 1 b) 

int x = 2, y = 3;
Console.WriteLine((double)x / y);
*/

/* Questão 1 c)
double x, y;
x = y = 0.0;

Console.WriteLine(x / y);
 */

/* Questão 1 d)
int x, y;
x = y = 0;

Console.WriteLine(x / y);
*/

/* Questão 1 e)

static void metodo(int x, int y, int z)
{
  Console.WriteLine(z);
}

metodo(1, z: 0, y: 2);
*/

/* Questão 2
  public class Empregado
  {
      // Campo privado para armazenar o tipo de empregado
      private string tipoEmpregado;

      // Propriedade TipoEmpregado acessível apenas dentro da classe Empregado e suas classes derivadas
      protected string TipoEmpregado
      {
          get { return tipoEmpregado; }
          set { tipoEmpregado = value; }
      }

      // Método para exibir o tipo de empregado
      public void ExibirTipoEmpregado()
      {
          Console.WriteLine($"Tipo de Empregado: {TipoEmpregado}");
      }
  }

  // Classe derivada
  public class Gerente : Empregado
  {
      public Gerente()
      {
          // Exemplo de modificação da propriedade TipoEmpregado na classe derivada
          TipoEmpregado = "Gerente";
      }
  }

  class Program
  {
      static void Main(string[] args)
      {
          // Criando uma instância da classe derivada Gerente
          Gerente gerente = new Gerente();

          // Exibindo o tipo de empregado
          gerente.ExibirTipoEmpregado();
      }
  }
*/

/* Questão 3 

  // Codigo 1
  string[] marcas = {"VW", "Fiat", "Ford", "Hyundai"}; 
  foreach (string marca in marcas) 
  { 
      Console.WriteLine(marca); 
  }

  // Codigo 2
  private static void Saudacao(string[] args)
  {
      Console.WriteLine("Olá, Mundo!");
  }

  // Codigo 3
  double numero; 
  Console.WriteLine("Digite um número:"); 
  while(!double.TryParse(Console.ReadLine(), out numero)) 
      Console.WriteLine("Valor incorreto");


  // Codigo 4
try
{
    int[] numeros = { 1, 2, 3 };
    Console.WriteLine(numeros[10]);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Algo errado.");
}
finally
{
    Console.WriteLine("Exemplo 'try catch'.");
}


// Codigo 5
int num = 9;
// duvida: Se fosse float seria necessário adicionar o sufixo 'f' 
//float numfloat = 8.99f;
double numfloat = 8.99;
char letra = 'A';
bool booleano = false;
string texto = "Olá, mundo";

Console.WriteLine(numfloat);

// duvida: tem como mudar o valor armazendo para apenas duas casas decimais?
// sim:
numfloat = 8.99;
numfloat = Math.Round(numfloat, 2); // Arredonda para duas casas decimais

Console.WriteLine(numfloat);

// arredondar só na hora de mostrar
numfloat = 8.99999999;
Console.WriteLine($"{numfloat:F2}"); // Imprime 8.99
*/