/*- ¿Qué es el formato compuesto? 

El formato compuesto usa marcadores de posición numerados dentro de una cadena.
En tiempo de ejecución, todo lo que hay dentro de las llaves se resolverá en un valor que también se pasa en función de su posición.


En el ejemplo siguiente de formato compuesto se usa un método Format() integrado en la palabra clave de tipo de datos string:
*/
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result+ "\n");

/* el resultado es el siguiente:
Hello World!

.-Hay algunas aspectos importantes que tener en cuenta sobre este código:

- Los tipos de datos y las variables de un tipo de datos determinado tienen "métodos auxiliares" integrados para facilitar tareas concretas.
- La cadena literal "{0} {1}!" forma una plantilla, y algunos de sus elementos se reemplazarán en tiempo de ejecución.
- El token {0} se reemplaza por el primer argumento después de la plantilla de cadena, es decir, el valor de la variable first.
- El token {1} se reemplaza por el segundo argumento después de la plantilla de cadena, es decir, el valor de la variable second. */

/* Pongamos otro ejemplo:
 */

/* string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second); */

/* Resultado:
World Hello!
Hello Hello Hello!
 
 
- Para la primera instrucción Console.WriteLine(), observe que los tokens se pueden organizar en cualquier orden. El código de ejemplo tiene {1} antes de {0}.
- Para la segunda instrucción Console.WriteLine(), observe que los tokens se pueden reutilizar con tres instancias de {0}. 
- No se usa el segundo argumento de variable, second. Sin embargo, el código todavía se ejecuta sin errores.*/




/*- ¿Qué es la interpolación de cadenas?
La interpolación de cadenas es una técnica que simplifica el formato compuesto.

En lugar de usar un token numerado e incluir el valor literal o el nombre de la variable en una lista de argumentos para String.Format() o Console.WriteLine(),
se puede usar simplemente el nombre de la variable dentro de las llaves.

Para que una cadena se pueda interpolar, debe agregarle la directiva $ como prefijo.
Ahora crearemos los mismos ejemplos anteriores en los que se usa la interpolación de cadenas en lugar del formato compuesto: */

/* string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}! \n");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!"); */


/* - Aplicación de formato a valores de moneda */

/* El formato compuesto y la interpolación de cadenas se pueden usar para dar formato a valores que se muestran en función de un idioma y una referencia cultural concretos.
En el ejemplo siguiente, se usa el especificador de formato de moneda :C para presentar las variables price y discount como moneda: */

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

/* Resultado:
Price: 123,45 ? (Save 50,00 ?)

Observe que si se agrega :C a los tokens incluidos entre las llaves, se aplica formato de moneda al número, independientemente de si se usa int o decimal. */