/*j) Desenvolva um programa que exiba a soma dos números pares entre 1 e 100. */

using System;

class Program {
  public static void Main (string[] args) {

    // Para fazer o cálculo é necessário a soma ser incializada com 0.
     int soma = 0;
  // O inicializador deve começar com 2, pois o primeiro número par é 2 e o incremento será de 2 em 2.
for (int i = 2; i <= 100; i += 2) {
    soma += i;
}
// Saída de dados
Console.WriteLine("A soma dos números pares entre 1 e 100 é igual a {0}.", soma);
  }
}