class URI
{
    static void Main(string[] args)
    {
        int horas = Int32.Parse(Console.ReadLine());
        int velocidade = Int32.Parse(Console.ReadLine());
        double padrao = 12.000;

        double litros = ((velocidade / padrao) * horas);

        Console.WriteLine($"{litros:0.000}");
    }
}