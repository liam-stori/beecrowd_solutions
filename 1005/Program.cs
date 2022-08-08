class URI
{
    static void Main(string[] args)
    {
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double media = (a * 3.5 + b * 7.5) / 11;

        Console.WriteLine($"MEDIA = {media:0.00000}");
    }
}