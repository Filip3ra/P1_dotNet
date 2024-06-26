﻿

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

int x = 0, y = 0;
Console.WriteLine(x / y);
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
      // private string tipoEmpregado;

      //A palavra propriedade indica este tipo de estrutura:
      // Propriedade TipoEmpregado acessível apenas dentro da classe Empregado e suas classes derivadas
      private string TipoEmpregado
      {
          get;
          set;
      } 

      //se fosse get publico e set só acessivel internamente
      // coloca public na definição 
      // Propriedade TipoEmpregado acessível apenas dentro da classe Empregado e suas classes derivadas
      public string TipoEmpregado
      {
          get;
          private set;
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
  foreach (string i in marcas) 
  { 
      Console.WriteLine(i); 
  }

  // Codigo 2
  private static void Main(string[] args)
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
    catch (IndexOutOfRangeException) // multiplos catchs permitidos desde que exceções sejam diferentes
    {
        Console.WriteLine("Algo errado.");
    }
    finally
    {
        Console.WriteLine("Exemplo 'try catch'.");
    }


    // Codigo 5
    int num = 9;
    // Se fosse float seria necessário adicionar o sufixo 'f' 
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

/* Questão 5 */


class Balanca
{
    private int precisao;
    private double tara = 5.0;
    private double peso;

    public Balanca(int precisao)
    {
        this.precisao = precisao;
    }

    public int Precisao
    {
        get { return precisao; }
        set { precisao = value; }
    }

    public double Tara
    {
        get { return tara; }
        set { tara = value; }
    }

    public double Peso
    {
        get { return peso; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Peso não pode ser negativo.");
            }
            peso = value;
        }
    }

    public string MostrarPeso
    {
        get
        {
            double pesoSemTara = Peso - Tara;
            return $"{pesoSemTara.ToString($"F{Precisao}")} kg";
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a precisão da balança:");
        int precisao = int.Parse(Console.ReadLine());
        Balanca balanca = new Balanca(precisao);

        while (true)
        {
            try
            {
                Console.WriteLine("Digite o peso na balança:");
                double peso_ = double.Parse(Console.ReadLine());
                balanca.Peso = peso_;
                Console.WriteLine(balanca.MostrarPeso);

                Console.WriteLine("Deseja calcular o próximo peso? (S/N): ");
                string continuar = Console.ReadLine();
                if (continuar.ToUpper() == "N")
                {
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido. Por favor, insira um número válido.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

/* 
public class Balanca
{

    private int precisao;
    private double tara = 5.0;
    private double peso;

    public Balanca(int pre)
    {
        this.precisao = pre;
    }

    public int Precisao
    {
        get; set;
    }
    public double Tara
    {
        get; set;
    }

    public double Peso
    {
        get { return peso; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("exceçao ai");
            else
                peso = value;
        }
    }
    public string MostraPeso()
    {
        double pesoMenosTara = Peso - Tara;
        return $"{pesoMenosTara.ToString($"F{Precisao}")} kg";
    }
}

class Program
{
    static void Main()
    {
        Balanca balanca = new(3);
        balanca.Peso = 10.0;
        Console.WriteLine(balanca.MostraPeso());

    }
}


/* Questão gpt

public class ContaBancaria
{

    double saldo;
    double limite = 0.0;
    string numConta;
    string nomeTitular;
    public ContaBancaria(string numConta, string nomeTitular)
    {
        this.numConta = numConta;
        this.nomeTitular = nomeTitular;
    }

    public string NumConta
    {
        get { return numConta; }
        set { numConta = value; }
    }
    public string NomeTitular
    {
        get { return nomeTitular; }
        set { nomeTitular = value; }
    }
    public double Limite
    {
        get { return limite; }
        set { limite = value; }
    }

    public double Saldo
    {
        get { return saldo; }
        set
        {
            if (saldo < 0)
                throw new ArgumentOutOfRangeException("...");
            else
                saldo = value;
        }
    }

    public string ExibirSaldo()
    {
        return $"R$ {Saldo:F2}";
    }

    public void Depositar(double valor)
    {
        Saldo = valor;
    }

}


class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("123456", "Filipi");
        conta.Depositar(1000);
        Console.WriteLine(conta.ExibirSaldo());


    }
}
*/