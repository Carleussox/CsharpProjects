///
/* EL MÉTODO SORT */
/* A continuación usaremos el método Sort() de la clase Array para ordenar los elementos de la matriz de forma alfanumérica. */
//string[] pallets = ["B14", "A11", "B12", "A13"];

/* 
//
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("Reversing pallets: ");
Console.ReadLine();
//

 */
/* Para invertir el orden de los palés podemos hacerlo mediante el método Array.Reverse() */
/* 
//Array.Reverse(pallets);

foreach(var pallet in pallets){
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("Reversed...."); 
//
*/


/* Si quisiéramos ver el interior del array después de vaciarlo parcialmente, el compilador transformaría el valor de null a una cadena vacía */

//

/* Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
 */
//



/* En cambio, si queremos demostrar que el compilador está transformando el valor de null podremos comprobarlo a partir del método toLower() */
//

/* Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */
//
/* RESULTADO:
Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
   at Program.<Main>$(String[] args) in D:\CsharpProjects\04Trabajo-Con-Datos-Variables-En-Consola\02OperacionesDeMatricesConMetodosAuxiliares\Sort-and-Reverse-Detection\Program.cs:line 55 */

///

///
/* CAMBIO DE TAMAÑO DE LA MATRIZ PARA AÑADIR NUEVOS ELEMENTOS */

/* A Continuación usaremos el método .Resize(), aunque puede ser útil para incluir nuevas entradas a la matriz, tiene sus
peculiaridades que veremos ahora: */
//
/* Array.Clear(pallets,0,2);

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"resizing 6 ... count {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets){
    Console.WriteLine("-- " + pallet);
}

Console.ReadLine();

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
} */

//

/* RESULTADO:
Clearing 2 ... count: 4
--
--
-- B12
-- A13

Resizing 6 ... count: 6
--
--
-- B12
-- A13
-- C01
-- C02

Resizing 3 ... count: 3
--
--
-- B12

//Aunque se ha aumentado el tamaño de la matriz, se han sustituido las primeras entradas aunque conteniesen
valores string.

Teniendo esto en cuenta, la mejor manera de quitar elementos nulos a una matriz sería creando otra matriz
que recorra la primera ignorando estos elementos, con el fin de hacer de sustituto para la primera matriz.

//
 */
///
 
///
/* DEL USO DE SPLIT() y JOIN() */


//
/*ToCharArray() se usa para crear una matriz char, donde cada elemento de la matriz representa un carácter de la cadena original.

Si queremos manipular strings a partir de caracteres hay que recordar el forzar el cambio de tipo a String para evitar problemas en código más complejo
*/

/* 
string value = "abc123";
char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);
string result = new string (valueArray);
Console.WriteLine(result);
 */
/* RESULTADO:
321cba
 */

/*
.Join() crea un string a partir de un array de caracteres o a partir de varias cadenas, además,
puede introducir un string entre cada valor de la cadena presentada.
 usaremos String.Join() para incluir una coma en la matriz de caracteres para dividirlos
 
 */
/* 
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = string.Join(",",valueArray);
Console.WriteLine(result);
 */

/* 
RESULTADO:
3,2,1,c,b,a
 */


/* El método Array.Split(), en cambio, crea fragmentos de Strings(cadenas) a partir de un String más grande
tomando como referencia strings internos.

En este ejemplo, volveremos a separar la cadena principal en un array de caracteres,
mostrando primero el string result y luego el array items.
 */

/*  string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
 */

 /* RESULTADO:
 
 3,2,1,c,b,a
3
2
1
c
b
a
 
  */
//
///