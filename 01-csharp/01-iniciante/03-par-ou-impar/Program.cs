// Exercicio 03 - Par ou impar
// Nivel: Iniciante | Categoria: Condicao
// Enunciado: Crie um programa que receba um numero inteiro e diga se ele e PAR ou IMPAR.
// Saidas esperadas nos testes:
// - Entrada: 4 | Saida: PAR
// - Entrada: 7 | Saida: IMPAR
// - Entrada: 0 | Saida: PAR

using System;

Console.WriteLine("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine()!);

string ParOuImpar = n % 2 == 0
                ? "PAR"
                : "IMPAR";

Console.WriteLine(ParOuImpar);