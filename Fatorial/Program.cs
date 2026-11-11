// 5- Faça um programa que leia um numero longeiro e exiba seu calculo fatorial.

Console.Write("Digite um número longeiro: ");
long numero = long.Parse(Console.ReadLine());

if (numero > 0)
{
    long fatorial = 1;

    for (long i = 1; i <= numero; i++)
    {
        fatorial *= i;
    }

    Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número longeiro e positivo.");
}
