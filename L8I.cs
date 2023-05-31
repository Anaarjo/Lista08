/*
i) Crie um programa que exiba todos os números primos entre 1 e 100.
*/

using System;

class Program {
  public static void Main (string[] args) {
  // O 1º for é usado para uma range de 1 até 100
   for (int i = 2; i <= 100; i++) {
     // O segundo for é para mostrar os números primos
  /*Para mostrar é necessário usar bool */
    bool Primo = true;
    for (int j = 2; j < i; j++) {
      // Se o número pode ser divido por 2 é falso 
        if (i % j == 0) {
            Primo = false;
            break;
        }
    }
     // Caso contrário, o número é primo 
    if (Primo) {
        Console.Write(i + " ");
    }
}
  }
}