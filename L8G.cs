/*
g) Crie um programa que exiba a tabuada do número 5 até o número 10.
*/
using System;

class Program {
  public static void Main (string[] args) {

	
        for (int table = 5; table <= 10; table++) {
    
    for (int i = 1; i <= 10;  i++)
  
			{	 
        
				Console.WriteLine("A multiplicação de {0} x {1} = {2}", table ,i, (table * i ));
       
			}
       Console.WriteLine(" ");
          }
  }
}