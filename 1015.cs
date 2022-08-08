class URI
{
    static void Main(string[] args)
    {
        string[] p1 = Console.ReadLine().Split(' ');
        string[] p2 = Console.ReadLine().Split(' ');

        double x1 = Double.Parse(p1[0]);
        double y1 = Double.Parse(p1[1]);
        double x2 = Double.Parse(p2[0]);
        double y2 = Double.Parse(p2[1]);

        double calculo = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

        Console.WriteLine($"{calculo:0.0000}");
    }
}