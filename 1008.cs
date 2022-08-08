class URI
{
    static void Main(string[] args)
    {
        int number = Int32.Parse(Console.ReadLine());
        int horas = Int32.Parse(Console.ReadLine());
        decimal valor = Decimal.Parse(Console.ReadLine());

        decimal salario = valor * horas;

        Console.WriteLine($"NUMBER = {number}\nSALARY = U$ {salario}");
    }
}