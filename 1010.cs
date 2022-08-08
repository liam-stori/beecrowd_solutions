class URI
{
    static void Main(string[] args)
    {
        string[] pecas1 = Console.ReadLine().Split(' ');
        string[] pecas2 = Console.ReadLine().Split(' ');

        int peca1 = int.Parse(pecas1[0]);
        int numPeca1 = int.Parse(pecas1[1]);
        double valor1 = double.Parse(pecas1[2]);

        int peca2 = int.Parse(pecas2[0]);
        int numPeca2 = int.Parse(pecas2[1]);
        double valor2 = double.Parse(pecas2[2]);

        double totalValor1 = numPeca1 * valor1;
        double totalValor2 = numPeca2 * valor2;

        double totalGeral = totalValor1 + totalValor2;

        Console.WriteLine($"VALOR A PAGAR: R$ {totalGeral:0.00}");
    }
}