class URI
{
    static void Main(string[] args)
    {
        double n = 3.14159;
        double raio = Double.Parse(Console.ReadLine());
        raio *= raio;

        double area = raio * n;

        Console.WriteLine($"A={area:0.0000}");
    }
}