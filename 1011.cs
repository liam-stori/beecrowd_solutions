class URI
{
    static void Main(string[] args)
    {
        double volume = Double.Parse(Console.ReadLine());
        double pi = 3.14159;
        double formula = (4.0 / 3) * pi * Math.Pow(volume, 3);

        Console.WriteLine($"VOLUME = {formula:0.000}");
    }
}