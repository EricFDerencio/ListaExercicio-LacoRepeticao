// 1- Faça im programa que leia um numero inteiro e faça sua tabuada de 1 a 10.


int numero;

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}