/* 
f) Desenvolva um programa que solicite ao usuário para inserir uma sequência
de números inteiros e, em seguida, exiba o maior número inserido.
*/


using System;

class Program {
  public static void Main (string[] args) {
    //Variáveis
    /* Será necessário uma variável para armazenar o maior valor e uma variável para determinar a quantidade de vezes que o programa irá rodar.
    Neste caso queremos que o programa rode 3 vezes, então declaramos a quantidade igual a 3. E a variável para receber o maior número tem que ser incializada com o valor 0, pois irá pegar de início o número que a pessoa digitar.*/
    
    int maior = 0;
    int quantidade = 3;
  /* Começa com (1; 1 <= 3; i = i + 1) */
    for (int i = 1; i <= quantidade; i++ )
 
  {
    Console.Write("Digite o  {0} º número: ", i);
    int n = Convert.ToInt32(Console.ReadLine());

  
    if (n > maior)
    {
      // Variável para receber o maior número 
      maior = n;
    }
     }
    // Saída de dados, irá imprimir o maior número digitado entre as 3 tentativas
   Console.Write("O maior número é: {0}", maior);  
   
  }
}