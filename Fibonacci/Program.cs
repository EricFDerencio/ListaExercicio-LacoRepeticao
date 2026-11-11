// 2 - Faça um programa que leia um numero inteiro esse numero é a posição até a onde a sequencia de Fibonacci deve ser exibida.

int numero;

Console.WriteLine("Digite a posição até onde a sequência de Fibonacci deve ser exibida:");
numero = int.Parse(Console.ReadLine());

int primeiro = 0, segundo = 1, proximo;

for (int i = 0; i < numero; i++)
{
    if (i <= 1)
        proximo = i;
    else
    {
        proximo = primeiro + segundo;
        primeiro = segundo;
        segundo = proximo;
    }
}