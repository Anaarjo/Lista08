/*b) Desenvolva um programa que solicite ao usuário para inserir um número
inteiro positivo e, em seguida, exiba todos os números pares entre 0 e o
número inserido. */


using System;

class Program {
  public static void Main (string[] args) {
    // Variáveis
    int n1;
    // Entrada de dados
    Console.Write("Por favor, digite um número inteiro: ");
    n1 = Convert.ToInt32(Console.ReadLine());
    // Sintaxe do for
    /* for (inicializador; i < condição ; incremento)
    {
    bloco de codigos 
    }
    
   Nesse caso o n1 será a nossa condição e o nosso incializador será o 0. Pq quer entre 0 e o numero inserido ( o n1 ). */
    for (int i = 0; i <= n1 ; i+=2)
    {
     Console.Write(i +  ".");
    }
    
  }
}