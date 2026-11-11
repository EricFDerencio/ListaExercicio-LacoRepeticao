// 4 - Faça um programa que leia um numero inteiro e mostre todos os numero primos até ele, inclusive ele se for primo.

int numero;

Console.WriteLine("Digite um numero: ");
numero = int.Parse(Console.ReadLine());

int contador;

Console.WriteLine("Sequencia: ");
for (int i = 2; i <= numero; i++){
    contador = 0;
    for (int j = i; j>=2; j--)
    {
        if (i % j == 0)
        {
            contador++;
        }
        if (contador > 1)
        {
            break;
        }
    }
    if (contador <= 1)
    {
        Console.WriteLine(i);
    }
}
