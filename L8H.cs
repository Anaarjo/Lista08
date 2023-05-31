/*
h) Desenvolva um programa que solicite ao usuário para inserir um número
inteiro positivo e, em seguida, exiba todos os divisores desse número.
*/


using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Digite um número inteiro positivo: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Os divisores de " + num + " são: ");
for (int i = 1; i <= num; i++) {
    if (num % i == 0) {
        Console.Write(i + " ");
    }
}
  }
}