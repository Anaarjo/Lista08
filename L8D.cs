/*d) Desenvolva um programa que solicite ao usuário para inserir um número
inteiro positivo e, em seguida, exiba a soma de todos os números entre 1 e o
número inserido. */

using System;

class Program {
  public static void Main (string[] args) {
    // Var
    int n1;
    int soma = 0;
    Console.Write("Digite um número: ");
    n1 = Convert.ToInt32(Console.ReadLine());
    
   for (int i = 1; i <= n1 ; i++ )
  {
     soma += i;
            }
    
     Console.WriteLine("A soma dos números inseridos é: {0} ", soma);
  
   
  }
}