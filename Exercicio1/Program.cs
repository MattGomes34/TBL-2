class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento genérico...");
    }
}

class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento com Cartão de Crédito.");
    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Boleto bancário gerado. Aguardando compensação.");
    }
}

class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento via Pix confirmado.");
    }
}

class Program
{
    static void Main()
    {
        List<Pagamento> pagamentos = new List<Pagamento>();

        pagamentos.Add(new CartaoCredito());
        pagamentos.Add(new BoletoBancario());
        pagamentos.Add(new Pix());

        foreach (Pagamento p in pagamentos)
        {
            p.ProcessarPagamento();
        }
    }
}