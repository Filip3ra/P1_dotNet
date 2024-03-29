

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

*/

