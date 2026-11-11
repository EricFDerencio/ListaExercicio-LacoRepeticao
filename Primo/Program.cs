// 4 - Faça um programa que leia um numero inteiro e mostre todos os numero primos até ele, inclusive ele se for primo.

bool EhPrimo(int numero)
{
    if (numero <= 1) return false;

    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0) return false;
    }
    return true;
}

void ImprimePrimos(int numero)
{
    Console.WriteLine("Sequencia de primos");
    if (numero <= 1)
    {
        Console.WriteLine("Não tem Numeros primos na sequencia :C");
    }
    else
    {
        for (int i = 2; i <= numero; i++)
        {
            if (EhPrimo(i)) { Console.WriteLine(i); }
        }
    }
}

Console.WriteLine("Digite seu numero:");
ImprimePrimos(int.Parse(Console.ReadLine()));

