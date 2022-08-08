class URI
{
    static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        double fixo = Double.Parse(Console.ReadLine());
        double vendas = Double.Parse(Console.ReadLine());

        double total = fixo + (vendas / 100) * 15;

        Console.WriteLine($"TOTAL = R$ {total:0.00}");
    }
}