/* Iteración for básica: */
/* for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
} */

/* Uso de Break
                        SOLO USAR EN CASOS DE VIDA O MUERTE

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
 */

/* 
Un uso habitual de la instrucción for es recorrer en iteración una matriz de elementos,
en especial si se necesita cierto control sobre la manera en la que la iteración se produce.
Si bien foreach recorre en iteración todos los elementos de la matriz, la instrucción for se puede ajustar para proporcionar una mayor personalización.


 string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}


  NOTA

Podríamos haber iterado hacia delante por los elementos de matriz mediante la construcción de la instrucción for como se indica a continuación:
 for (int i = 0; i < names.Length; i++).
 
 */

/* 
//A diferencia del FOR el FOREACH no puede ser actualizado usando únicamente la matriz, necesitaríamos hacer uso de un iterador externo, digamos que queremos sustituir David por Sammy

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
   // Can't do this:
   if (name == "David") name = "Sammy";
}

// En cambio, el bucle FOR da mucho mas control a la hora de hacer operaciones complejas con la matriz/objeto si el objetivo existe más allá de la iteración

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
   if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name); 

*/



/* EJERCICIO FIZZBUZZ

FizzBuzz es un conocido desafío de codificación y un tema que se suele plantear en las entrevistas. 
Sirve para ejercitar la comprensión de las instrucciones for y if, el operador de resto % y el dominio de la lógica básica.

Desafío de código: Implementación de las reglas de desafío de FizzBuzz
Estas son las reglas de FizzBuzz que necesita implementar en el proyecto de código:

-Valores de salida de 1 a 100, un número por línea, dentro del bloque de código de una instrucción de iteración.
-Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
-Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
-Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.
   1.-Asegúrese de que tiene un archivo Program.cs vacío abierto en Visual Studio Code.

   Si es necesario, abra Visual Studio Code y, luego, lleve a cabo los pasos siguientes para preparar un archivo Program.cs en el editor:

       a)En el menú Archivo, seleccione Abrir carpeta.

       b)Use el cuadro de diálogo "Abrir carpeta" para ir a la carpeta CsharpProjects.

       c)En el panel EXPLORADOR de Visual Studio Code, seleccione Program.cs.

       d)En el menú Selección de Visual Studio Code, elija Seleccionar todo y presione la tecla Supr.

   2.-Escriba el código que implementa cada regla.

   3.-Ejecute la aplicación y compruebe que la salida cumple los requisitos.

Independientemente de cómo haya anidado la iteración y las instrucciones condicionales, el código debe generar la salida siguiente:

1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
11
12 - Fizz
13
14
15 - FizzBuzz
16
17
18 - Fizz
19
20 - Buzz
21 - Fizz
22
.
.
.

(Se asume que llega hasta 100, esto es un ejemplo del principio)
 */

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.Write($"{i} - Fizz");
            if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }else{
            Console.WriteLine($"{i} - Fizz");
        }
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
        Console.WriteLine(i);
}