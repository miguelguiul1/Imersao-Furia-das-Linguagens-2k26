// Exercicio 05 - Contagem de 1 ate N
// Nivel: Iniciante | Categoria: Repeticao
// Enunciado: Crie um programa que receba um numero N e mostre todos os numeros de 1 ate N.
// Saidas esperadas nos testes:
// - Entrada: 5 | Saida: 1 2 3 4 5
// - Entrada: 3 | Saida: 1 2 3
// - Entrada: 1 | Saida: 1

using System;

Console.WriteLine("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i} ");
}


