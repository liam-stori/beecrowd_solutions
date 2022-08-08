class URI
{
    static void Main(string[] args)
    {
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double c = Double.Parse(Console.ReadLine());
        double media = (a * 2 + b * 3 + c * 5) / 10;

        Console.WriteLine($"MEDIA = {media:0.0}");
    }
}