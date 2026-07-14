// Exercicio 04 - O maior de dois
// Nivel: Iniciante | Categoria: Condicao
// Enunciado: Crie um programa que receba dois numeros e mostre o maior deles. Se forem iguais, mostre IGUAIS.
// Saidas esperadas nos testes:
// - Entrada: 3, 9 | Saida: 9
// - Entrada: 10, 2 | Saida: 10
// - Entrada: 5, 5 | Saida: IGUAIS

using System;

Console.WriteLine("Primeiro número: ");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Segundo número: ");
int n2 = int.Parse(Console.ReadLine()!);

if (n1 > n2)
{
    Console.WriteLine($"\nMaior número é {n1}");
}
else if (n2 > n1)
{
    Console.WriteLine($"\nMaior número é {n2}");
}
else
{
    Console.WriteLine("\nIGUAIS");
}



