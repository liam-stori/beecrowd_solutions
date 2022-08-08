class URI
{
    static void Main(string[] args)
    {
        int idade = Int32.Parse(Console.ReadLine());
        int ano = 365;
        int mes = 30;
        int dia = 1;
        int contadorAno = 0;
        int contadorMes = 0;
        int contadorDia = 0;

        if (idade >= ano)
        {
            while (idade >= ano)
            {
                idade -= ano;
                contadorAno++;
            }
        }
        if (idade >= mes)
        {
            while (idade >= mes)
            {
                idade -= mes;
                contadorMes++;
            }
        }
        if (idade >= dia)
        {
            while (idade >= dia)
            {
                idade -= dia;
                contadorDia++;
            }
        }

        Console.WriteLine($"{contadorAno} ano(s)");
        Console.WriteLine($"{contadorMes} mes(es)");
        Console.WriteLine($"{contadorDia} dia(s)");
    }
}