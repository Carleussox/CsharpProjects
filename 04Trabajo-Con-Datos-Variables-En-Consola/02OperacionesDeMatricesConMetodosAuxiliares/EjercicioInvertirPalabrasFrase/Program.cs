/* Ejercicio: Complete un desafío para invertir las palabras de una oración

-Escribir código para invertir cada palabra de un mensaje

-En otras palabras, no vamos a revertir simplemente cada letra de la variable pangram,
En su lugar, debe invertir solo las letras de cada palabra, pero imprimir la palabra invertida en su posición original en el mensaje. 

-RESULTADO ESPERADO:
ehT kciuq nworb xof spmuj revo eht yzal god

*/

string pangram = "The quick brown fox jumps over the lazy dog";

string [] words = pangram.Split(" ");



 for (int i = 0; i< words.Length; i++){
    char[] wordArray =  words[i].ToCharArray();
    Array.Reverse(wordArray);
    words[i] = new string (wordArray);
} 

pangram = string.Join(" ", words);

Console.WriteLine(pangram);