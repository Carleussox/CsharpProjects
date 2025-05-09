/*- ¿QUÉ ES EL FORMATO COMPUESTO?

El formato compuesto usa marcadores de posición numerados dentro de una cadena.
En tiempo de ejecución, todo lo que hay dentro de las llaves se resolverá en un valor que también se pasa en función de su posición.


En el ejemplo siguiente de formato compuesto se usa un método Format() integrado en la palabra clave de tipo de datos string:
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result+ "\n");
*/

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




/*- ¿QUÉ ES LA INTERPOLACIÓN DE CADENAS?
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
En el ejemplo siguiente, se usa el especificador de formato de moneda :C para presentar las variables price y discount como moneda: 



decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
 
/*-Resultado:
Price: 123,45 ? (Save 50,00 ?)

Observe que si se agrega :C a los tokens incluidos entre las llaves, se aplica formato de moneda al número, independientemente de si se usa int o decimal. 

Desafortunadamente, resulta complicado asegurarse de que el código funciona correctamente en todos los equipos con independencia del país y región o el idioma del usuario final.
Este proceso se conoce como localización (o globalización). La localización depende de muchos factores que no se tratan en este módulo pero, básicamente,
la sintaxis del formato de cadena podría usar un formato diferente en función de la referencia cultural del usuario.
*/


/*- APLICACIÓN DEL FORMATO A NÚMEROS */

/* Al trabajar con datos numéricos, podría querer dar formato al número para facilitar la lectura mediante la inclusión de puntos para delimitar miles, millones, miles de millones, etc.

El especificador de formato numérico N hace que los números se lean mejor.  Por ejemplo: 

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
*/

/* 
-Resultado:

Measurement: 123,456.79 units */

/* De forma predeterminada, el especificador de formato numérico N solo muestra dos dígitos después del separador decimal.

Si quiere mostrar más precisión, puede agregar un número después del especificado:

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
 */


/*
- Resultado:

Measurement: 123,456.7891 units
  */

/*- APLICACIÓN DEL FORMATO A PORCENTAJES */

/* 
Se puede usar el especificador de formato P para dar formato a porcentajes y redondeos a 2 posiciones decimales.
Podemos agregar un número después para controlar el número de valores que se muestran detrás del separador decimal. Por ejemplo:



decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}"); 
*/

/* 
-RESULTADO:

Tax rate: 36,79 %
*/

/*- COMBINACIÓN DE LOS ENFOQUES DEL FORMATO */

/* Las variables de cadena pueden almacenar cadenas creadas mediante técnicas de formato.
En el ejemplo siguiente, se da formato a decimales y resultados matemáticos decimales y se almacenan en la cadena yourDiscount con formato compuesto: 


decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);
*/

/* 
- RESULTADO:

You saved 7,56 ? off the regular 67,55 ? price.
 */

 /* -RESUMEN:

- Puede usar el formato compuesto o la interpolación de cadenas para dar formato a las cadenas.

- Con el formato compuesto, se usa una plantilla de cadena que contiene uno o más tokens de reemplazo con el formato {0}.
 También se proporciona una lista de argumentos que se comparan con los tokens de reemplazo según su orden. El formato compuesto funciona cuando se usa string.Format() o Console.WriteLine().

- Con la interpolación de cadenas, se usa una plantilla de cadena que contiene los nombres de variable que se quieren reemplazar entre llaves.
 Se usa la directiva $ antes de la plantilla de cadena para indicar que se quiere interpolar la cadena.

- Se aplica formato a los valores de moneda mediante un especificador :C.

- Se aplica formato a los números mediante un especificador :N. La precisión (el número de valores después del separador decimal) se controla mediante un número después de :N,
 como en {myNumber:N3}.

- Use el especificador de formato :P para dar formato a los porcentajes.

- El formato de moneda y número depende de la referencia cultural del usuario final, un código de cinco caracteres que incluye el país o la región y el idioma del usuario (según la configuración del equipo).
 
  */




