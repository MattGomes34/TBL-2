abstract class Funcionario
{
    public string Nome { get; set; }

    public Funcionario(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();
}

class Gerente : Funcionario
{
    public Gerente(string nome) : base(nome) { }

    public override double CalcularSalario()
    {
        double salarioBase = 8000;
        double bonus = 2000;
        return salarioBase + bonus;
    }
}

class Programador : Funcionario
{
    public Programador(string nome) : base(nome) { }

    public override double CalcularSalario()
    {
        double horasTrabalhadas = 160;
        double valorHora = 45;
        return horasTrabalhadas * valorHora;
    }
}

class Program
{
    static void Main()
    {
        Gerente gerente = new Gerente("Carlos");
        Programador programador = new Programador("Ana");

        Console.WriteLine($"Salário do gerente {gerente.Nome}: R$ {gerente.CalcularSalario():F2}");
        Console.WriteLine($"Salário do programador {programador.Nome}: R$ {programador.CalcularSalario():F2}");

        // Desafio adicional
        Console.WriteLine("\n--- Lista de funcionários ---");

        List<Funcionario> funcionarios = new List<Funcionario>();
        funcionarios.Add(gerente);
        funcionarios.Add(programador);

        foreach (Funcionario f in funcionarios)
        {
            Console.WriteLine($"{f.Nome}: R$ {f.CalcularSalario():F2}");
        }
    }
}