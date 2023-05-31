/*
Crie um programa que solicite ao usuário para inserir uma palavra e, em
seguida, exiba cada letra da palavra em uma linha separada.
*/

using System;

class Program {
  public static void Main (string[] args) {
    // Declarando a variável do tipo string por ser uma palavra
    
   string palavraBorboleta = "Borboleta";

    
// Nesse caso iremos iniciar por 0 e ir até o tamanho da palavra (A palavra Borboleta tem 9 letras) e o incremento é de 1. 
// Então i = i + 1 que é a mesma coisa de i++ ou i+=1 ;
    
    /* Utilizando o for será necessário usar a função 
    Length para pegar o tamanho da variável.    */
    
// Será necessário usar o i como índice dentro do comando for, para saber a posição de cada letra e para imprimir a letra utiliza-se o Console.Write();
  // Os índices começam do 0 até o 8. Totalizando um comprimento de 9.
  
  // 0 - 1 - 2 - 3 - 4 - 5 - 6 - 7 - 8
  // B - o - r - b - o - l - e - t - a

  
    
for (int i = 0; i < palavraBorboleta.Length; i++) {
  
  
    char tamanhoB = palavraBorboleta[i];
    Console.WriteLine(tamanhoB);
}






    // 2º forma utilizando o foreach
    
    // variável
    string palavra;
    // Entrada de dados 
    Console.Write("Por favor digite uma palavra: ");
    palavra = Console.ReadLine();

    
  // Saiída de dados
    /*
    
    A sintexe dele é :
    
    foreach( tipo NomeDaVariável in VariavélDesejada)
    
    Nesse caso como queremos mostrar cada letra
    será utilizado o tipo char.
    */
    
    foreach (char transEmCaracter in palavra) {
    Console.WriteLine(transEmCaracter);
}
  }
}