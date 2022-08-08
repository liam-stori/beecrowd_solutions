class URI
{
    static void Main(string[] args)
    {
        int distancia = Int32.Parse(Console.ReadLine());
        double combustivel = Double.Parse(Console.ReadLine());

        double porLitro = distancia / combustivel;

        Console.WriteLine($"{porLitro:0.000} km/l");
    }
}