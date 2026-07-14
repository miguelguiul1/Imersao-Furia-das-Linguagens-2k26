// Exercicio 06 - Soma de 1 ate N
// Nivel: Iniciante | Categoria: Repeticao
// Enunciado: Crie um programa que receba N e mostre a soma de todos os numeros de 1 ate N.
// Saidas esperadas nos testes:
// - Entrada: 5 | Saida: 15
// - Entrada: 3 | Saida: 6
// - Entrada: 10 | Saida: 55

using System;

Console.WriteLine("Digite um número: ");
int n = int.Parse(Console.ReadLine()!);

int soma = 0;
for (int i = 1; i <= n; i++)
{
    soma += i;
}

Console.WriteLine($"A soma de 1 até {n} é: {soma}");
