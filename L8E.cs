/*e) Crie um programa que solicite ao usuário para inserir um número inteiro e,
em seguida, exiba se esse número é primo ou não. */

using System;

class Program {
  public static void Main (string[] args) {
// Variáveis
    
/* A variável n será o número que o usuário irá digitar */
int n;

/* Para ele ser primo é necessário ele ser dividido apenas por 1 e
    ele mesmo, totalizando 2 números. Para isso, é necessário um contador para verificar se ele pode ser divido por apenas 2 números ou não. Esse contador será inciado com o valor 0 com o nome quantD.*/
int quantD = 0;


// Entrada de dados
// Aqui será inserido o número para verificar se ele é primo ou nao.
Console.Write("Por favor, digite um número: ");
n = Convert.ToInt32(Console.ReadLine());

 // O for é usado para contar a quantidade de vezes que esse número pode ser divido.
    
         for (int i = 1; i <= n; i++)
   {
            if (n % i == 0) 
              {
               quantD++;
                }
         }
    // Saída de dados
    // Se o contador for igual a 2 ele será primo 
         if (quantD == 2) 
       {
            Console.WriteLine("{0} é um número primo.", n);
         } 
    // Caso contrário, ele não será primo 
    else
        {
            Console.WriteLine("Não é um número primo.");
         }
         Console.ReadLine();


  }
}