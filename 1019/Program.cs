class URI
{
    static void Main(string[] args)
    {
        int entrada = Int32.Parse(Console.ReadLine());

        int horas = entrada / 3600;
        int minutos = (entrada - (horas * 3600)) / 60;
        int segundos = entrada % 60;

        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}