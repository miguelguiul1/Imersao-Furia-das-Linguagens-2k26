// Exercicio 01 - Soma de dois numeros
// Nivel: Iniciante | Categoria: Operadores
// Enunciado: Crie um programa que receba dois numeros inteiros e mostre a soma dos dois.
// Saidas esperadas nos testes:
// - Entrada: 5, 3 | Saida: 8
// - Entrada: 10, 20 | Saida: 30
// - Entrada: -4, 4 | Saida: 0

using System;

Console.Write("Digite o primeiro numero: ");
int primeiroNumero = int.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo numero: ");
int segundoNumero = int.Parse(Console.ReadLine()!);
int soma = primeiroNumero + segundoNumero;

Console.WriteLine($"A soma dos numeros é: {soma}");

