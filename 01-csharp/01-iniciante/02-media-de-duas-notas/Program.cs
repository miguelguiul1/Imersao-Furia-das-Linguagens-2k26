// Exercicio 02 - Media de duas notas
// Nivel: Iniciante | Categoria: Operadores
// Enunciado: Crie um programa que receba duas notas e mostre a media entre elas.
// Saidas esperadas nos testes:
// - Entrada: 8, 6 | Saida: 7
// - Entrada: 10, 5 | Saida: 7.5
// - Entrada: 7, 7 | Saida: 7

using System;



Console.WriteLine("Digite sua primeira nota: ");
int nota1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite sua segunda nota: ");
int nota2 = int.Parse(Console.ReadLine()!);

double media = (nota1 + nota2) / 2;

Console.WriteLine($"A média é: {media} ");

