class URI
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');

        double a = Double.Parse(valores[0]);
        double b = Double.Parse(valores[1]);
        double c = Double.Parse(valores[2]);

        double pi = 3.14159;

        double triangulo = (a * c) / 2;
        double circulo = pi * Math.Pow(c, 2);
        double trapezio = (((a + b) * c) / 2);
        double quadrado = b * b;
        double retangulo = a * b;

        Console.WriteLine($"TRIANGULO: {triangulo:0.000}\nCIRCULO: {circulo:0.000}\nTRAPEZIO: {trapezio:0.000}\nQUADRADO: {quadrado:0.000}\nRETANGULO: {retangulo:0.000}");
    }
}