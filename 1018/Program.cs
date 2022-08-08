class URI
{
    static void Main(string[] args)
    {
        int num = Int32.Parse(Console.ReadLine());
        int numInicial = num;
        int contadorCem = 0;
        int contadorCincoenta = 0;
        int contadorVinte = 0;
        int contadorDez = 0;
        int contadorCinco = 0;
        int contadorDois = 0;
        int contadorUm = 0;

        if (num > 100)
        {
            while (num >= 100)
            {
                num -= 100;
                contadorCem += 1;
            }
        }
        if (num < 100)
        {
            while (num >= 50)
            {
                num -= 50;
                contadorCincoenta += 1;
            }
        }
        if (num < 50)
        {
            while (num >= 20)
            {
                num -= 20;
                contadorVinte += 1;
            }
        }
        if (num < 20)
        {
            while (num >= 10)
            {
                num -= 10;
                contadorDez += 1;
            }
        }
        if (num < 10)
        {
            while (num >= 5)
            {
                num -= 5;
                contadorCinco += 1;
            }
        }
        if (num < 5)
        {
            while (num >= 2)
            {
                num -= 2;
                contadorDois += 1;
            }
        }
        if (num < 2)
        {
            while (num >= 1)
            {
                num -= 1;
                contadorUm += 1;
            }
        }

        Console.WriteLine(numInicial);
        Console.WriteLine(contadorCem + " nota(s) de R$ 100,00");
        Console.WriteLine(contadorCincoenta + " nota(s) de R$ 50,00");
        Console.WriteLine(contadorVinte + " nota(s) de R$ 20,00");
        Console.WriteLine(contadorDez + " nota(s) de R$ 10,00");
        Console.WriteLine(contadorCinco + " nota(s) de R$ 5,00");
        Console.WriteLine(contadorDois + " nota(s) de R$ 2,00");
        Console.WriteLine(contadorUm + " nota(s) de R$ 1,00");
    }
}