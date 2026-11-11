// 3 - Faça um programa que leia um numero inteiro e mostre primeiramente só os valores impares na ordem crescente e depois os valores pares na ordem decrescente de 1 até o numero digitado.

int numero;

Console.WriteLine("Digite um número:");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("Números ímpares em ordem crescente:");

for(int i = 1; i<= numero; i++)
{
    if(i%2 != 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("Números pares em ordem decrescente");

for(int i = numero; i >= 0; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}