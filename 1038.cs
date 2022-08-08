class URI
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        double[] valores = { 4.00, 4.50, 5.00, 2.00, 1.50 };

        int codigo = Int32.Parse(entrada[0]);
        int quantidade = Int32.Parse(entrada[1]);
        double valor = valores[codigo - 1] * quantidade;

        Console.WriteLine($"Total: R$ {valor.ToString("N")}");
    }
}