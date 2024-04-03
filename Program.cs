
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
