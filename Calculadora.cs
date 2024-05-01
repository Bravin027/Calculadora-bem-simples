using System;
using System.Globalization;


// Começar criando as opções de conta

Console.WriteLine("Escolha qual tipo de operação quer realizar");
Console.WriteLine("1.Adição");
Console.WriteLine("2.Subtração");
Console.WriteLine("3.Multiplicação");
Console.WriteLine("4.Divisão");
int escolha = int.Parse(Console.ReadLine());

// Criar as variaveis 

double a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p;


if (escolha == 1)
{
    Console.Write("Escolha a quantidade a se somar: ");
    int escolha1 = int.Parse(Console.ReadLine());

    if (escolha1 == 2)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a + b;

        Console.WriteLine("Resultado da adição: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();
        Console.Write("Deseja somar mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar somando: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 1)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                double resultado1 = (resultado) + c;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                double resultado1 = (resultado) + c + d;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e + f;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }
    else if (escolha1 == 3)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a + b + c;

        Console.WriteLine("Resultado da adição: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja somar mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar somando: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e + f;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e + f + g;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }


    else if (escolha1 == 4)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a + b + c + d;

        Console.WriteLine("Resultado da adição: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja somar mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar somando: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e + f;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e + f + g;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }

    else if (escolha1 == 5)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a + b + c + d + e;

        Console.WriteLine("Resultado da adição: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja somar mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar somando: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e + f;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) + c + d + e + f + g;

                Console.WriteLine("Resultado da adição: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }
}
if (escolha == 2)
{
    Console.Write("Escolha a quantidade a se subtrair: ");
    int escolha1 = int.Parse(Console.ReadLine());

    if (escolha1 == 2)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a - b;

        Console.WriteLine("Resultado da subtração: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();
        Console.Write("Deseja subtrair mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar subtraindo: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e - f;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e - f - g;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }
    else if (escolha1 == 3)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a - b - c;

        Console.WriteLine("Resultado da subtração: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja subtrair mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar subtraindo: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e - f;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e - f - g;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }


    else if (escolha1 == 4)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a - b - c - d;

        Console.WriteLine("Resultado da subtração: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja subtrair mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar subtraindo: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e - f;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e - f - g;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }

    else if (escolha1 == 5)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a - b - c - d - e;

        Console.WriteLine("Resultado da subtração: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja subtrair mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar subtraindo: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e - f;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) - c - d - e - f - g;

                Console.WriteLine("Resultado da subtração: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }
}
if (escolha == 3)
{
    Console.Write("Escolha a quantidade a se multiplicar: ");
    int escolha1 = int.Parse(Console.ReadLine());

    if (escolha1 == 2)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a * b;

        Console.WriteLine("Resultado da multiplicação: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();
        Console.Write("Deseja multiplicar mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar multiplicando: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d * e;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d * e * f;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d * e * f * g;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }
    else if (escolha1 == 3)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a * b * c;

        Console.WriteLine("Resultado da multiplicação: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja multiplicar mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar multiplicando: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d * e;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d * e * f;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d * e * f * g;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }


    else if (escolha1 == 4)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a * b * c * d;

        Console.WriteLine("Resultado da multiplicação: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja multiplicar mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar multiplicando: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 3)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d * e;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 4)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d * e * f;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 5)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                g = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c * d * e * f * g;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }

    else if (escolha1 == 5)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a * b * c * d * e;

        Console.WriteLine("Resultado da multiplicação: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja multiplicar mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar multiplicando: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 1)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado1 = (resultado) * c;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                double resultado1 = (resultado) * c * d;

                Console.WriteLine("Resultado da multiplicação: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }

            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }
}
if (escolha == 4)
{
    Console.Write("Escolha a quantidade a se dividir: ");
    int escolha1 = int.Parse(Console.ReadLine());

    if (escolha1 == 2)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a / b;

        Console.WriteLine("Resultado da divisão: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();
        Console.Write("Deseja dividir mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar dividindo: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 1)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                double resultado1 = (resultado) / c;

                Console.WriteLine("Resultado da divisão: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                double resultado1 = (resultado) / c / d;

                Console.WriteLine("Resultado da divisão: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }

            else { }
        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }
    else if (escolha1 == 3)
    {
        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = a / b / c;

        Console.WriteLine("Resultado da divisão: " + resultado.ToString(CultureInfo.InvariantCulture));
        Console.WriteLine();

        Console.Write("Deseja dividir mais alguma coisa? Digite 's' para 'sim' e 'n' para 'não' ");
        string sn = Console.ReadLine();




        if (sn == "s" || sn == "S")
        {
            Console.Write("Digite a quantidade para continuar divindo: ");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 1)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                double resultado1 = (resultado) / c;

                Console.WriteLine("Resultado da divisão: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }
            else if (escolha2 == 2)
            {
                c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                double resultado1 = (resultado) / c / d;

                Console.WriteLine("Resultado da divisão: " + resultado1.ToString(CultureInfo.InvariantCulture));
            }

        }
        else if (sn == "n" || sn == "N") { }
        else { }
    }
}