/*a) Crie um programa que exiba todos os números pares entre 0 e 100. */
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("De 0 a 100:");
    // Com o 0 e o 100 inseridos 
   for (int i = 0; i<=100; i+=2)
    {
      Console.Write(i + ".");
    }

    // Sem o 0 e o 100 inseridos
  Console.WriteLine("");
  Console.WriteLine("");
   Console.WriteLine("Entre 0 e 100: ");
    for (int i = 2; i<100; i+=2)
    {
      Console.Write(i + ".");
    }
    
  }
}