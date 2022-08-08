class URI
{
    static void Main(string[] args)
    {
        double valor = Double.Parse(Console.ReadLine()) + 0.00001;
        double comparador = 0;
        double[] valores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        if (valor > 100.00)
        {
            comparador = 100.00;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[0] += 1;
            }
        }
        if (valor > 50.00)
        {
            comparador = 50.00;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[1] += 1;
            }
        }
        if (valor > 20.00)
        {
            comparador = 20.00;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[2] += 1;
            }
        }
        if (valor > 10.00)
        {
            comparador = 10.00;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[3] += 1;
            }
        }
        if (valor > 5.00)
        {
            comparador = 5.00;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[4] += 1;
            }
        }
        if (valor > 2.00)
        {
            comparador = 2.00;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[5] += 1;
            }
        }
        if (valor > 1.00)
        {
            comparador = 1.00;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[6] += 1;
            }
        }
        if (valor > 0.50)
        {
            comparador = 0.50;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[7] += 1;
            }
        }
        if (valor > 0.25)
        {
            comparador = 0.25;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[8] += 1;
            }
        }
        if (valor > 0.10)
        {
            comparador = 0.10;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[9] += 1;
            }
        }
        if (valor > 0.05)
        {
            comparador = 0.05;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[10] += 1;
            }
        }
        if (valor > 0.01)
        {
            comparador = 0.01;
            while (valor >= comparador)
            {
                valor -= comparador;
                valores[11] += 1;
            }
        }

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{valores[0]} nota(s) de R$ 100.00");
        Console.WriteLine($"{valores[1]} nota(s) de R$ 50.00");
        Console.WriteLine($"{valores[2]} nota(s) de R$ 20.00");
        Console.WriteLine($"{valores[3]} nota(s) de R$ 10.00");
        Console.WriteLine($"{valores[4]} nota(s) de R$ 5.00");
        Console.WriteLine($"{valores[5]} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{valores[6]} moeda(s) de R$ 1.00");
        Console.WriteLine($"{valores[7]} moeda(s) de R$ 0.50");
        Console.WriteLine($"{valores[8]} moeda(s) de R$ 0.25");
        Console.WriteLine($"{valores[9]} moeda(s) de R$ 0.10");
        Console.WriteLine($"{valores[10]} moeda(s) de R$ 0.05");
        Console.WriteLine($"{valores[11]} moeda(s) de R$ 0.01");
    }
}