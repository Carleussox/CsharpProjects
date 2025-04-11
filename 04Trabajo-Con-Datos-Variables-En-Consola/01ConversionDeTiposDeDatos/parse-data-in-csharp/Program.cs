/* int first = 2;
string second = "5";
int result = first +second;
Console.WriteLine(result);


//Dará error, una variable int no puede trabajar implícitamente con una operación con un string//


 int first = 2;
 string second = "5";
 string result = first + second;
 Console.WriteLine(result);
 
 //No dará error una variable string puede trabajar implícitamente con una operación con un int//
 */
/* 
//¿es posible que el intento de cambiar el tipo de datos del valor provoque una pérdida de información?// 

int myInt = 3;
Console.WriteLine ($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine ($"decimal: {myDecimal}");

//Cualquier valor int puede adaptarse fácilmente dentro de un tipo decimal, de modo que el compilador realiza la conversión.

El término conversión de ampliación significa que intenta convertir un valor de un tipo de datos que podría contener menos información en un tipo de datos que puede contener más información.
En este caso, un valor almacenado en una variable de tipo int convertido en una variable de tipo decimal no pierde información.

Cuando sepa que va a realizar una conversión de ampliación, puede confiar en la conversión implícita. El compilador controla las conversiones implícitas.// */

/* 
//Para realizar una coerción, se usa el operador de coerción () para encerrar un tipo de datos y se coloca junto a la variable que se quiere convertir (ejemplo: (int)myDecimal).
Se realiza una conversión explícita al tipo de datos de coerción definido (int).// 

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");



*/



/* Determinación de si una conversión es "de ampliación" o "de restricción" */

/* 
//El término conversión de restricción significa que intenta convertir un valor de un tipo de datos que podría contener más información en uno con menos información.
 Cuando sepamos que va a realizar una conversión de restricción, debemos llevar a cabo una coerción. 
 La conversión es una instrucción que indica al compilador de C# que usted sabe que es posible que se pierda precisión, pero está dispuesto a aceptarlo.//

 decimal myDecimal = 1.23456789m;
 float myFloat = (float)myDecimal;

 Console.WriteLine($"Decimal: {myDecimal}");
 Console.WriteLine($"Float  : {myFloat}");
 */

/* Uso de ToString() para convertir un número en string */

/* 
//Todas las variables de tipo de datos tienen un método ToString(),
 en la mayoría de los primitivos, realiza una conversión de ampliación. 

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
*/

/* Conversión de un objeto string en int mediante la clase Convert */

/* 
// La clase Convert tiene muchos métodos auxiliares para convertir un valor de un tipo en otro. 
 En el siguiente ejemplo de código, vamos a convertir un par de cadenas en valores de tipo int.//

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);*/


/* Comparación de la coerción y conversión de un objeto decimal en int */

/*
//En el ejemplo siguiente se muestra lo que sucede cuando intenta convertir
un valor decimal en uno int (una conversión de restricción) en lugar de usar el método Convert.ToInt32() para convertir ese valor decimal en int.//


int value = (int)1.5m; // coercionar trunca
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // convertir redondea hacia arriba
Console.WriteLine(value2);

*/

/* Uso de TryParse() */

/* 
//
Intenta analizar una cadena en el tipo de datos numérico indicado.
Si se ejecuta correctamente, almacena el valor convertido en un parámetro out, que se explica en la sección siguiente.
Devuelve un valor bool para indicar si la acción se ha podido realizar correctamente o no.
// 

string value = "102";
int result = 0;
if (int.TryParse(value, out result)){
    Console.WriteLine($"Measurement: {result}");
}else{
    Console.WriteLine("Unable to report the measurement. ");
}
//
El valor convertido se almacena en la variable intresult. En la variable int, result se declara y se inicializa antes que esta línea de código,
 por lo que debería ser accesible tanto dentro de los bloques de código que pertenecen a las instrucciones if y else como fuera de ellos.
//
*/

/* Modificación de la variable de cadena a un valor que no se pueda analizar con TryParse()*/
/*
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//
Puesto que result se define fuera de la instrucción if, se puede acceder a result más adelante en el código fuera de los bloques de código. 
Por lo tanto, se puede comprobar que haya en result un valor mayor que cero antes de permitir que result + desplazamiento se escriba como salida. 
La comprobación de que el valor de result sea mayor que cero evita imprimir un valor de desplazamiento después del mensaje Unable to report the measurement..
// 
*/