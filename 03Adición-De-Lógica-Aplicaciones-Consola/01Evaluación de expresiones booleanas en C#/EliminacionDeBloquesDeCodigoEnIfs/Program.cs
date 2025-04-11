/* 
/////////////////////Bien, es corto y se distingue////////////////////

bool flag = true;
if (flag)
    Console.WriteLine(flag);
 */

 ////////////////////////Mal, es largo, muy pegado y corre el riesgo de resultar ilegible/////////////////
 

/*  string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
 */

//////////////Organizándolo así se distingue mucho mejor el funcionamiento del bloque/////////////

/* string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
 */



//////////////EJERECICIO DE REFACTORIZACIÓN DE CÓDIGO


int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
           Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
















 /*                                         RESUMEN


Estos son algunos aspectos importantes que hay que recordar sobre los bloques de código de instrucciones if y la legibilidad:

Si se da cuenta de que solo tiene una línea de código enumerada en los bloques de código de una instrucción if-elseif-else, puede quitar las llaves del bloque de código y el espacio en blanco.
Microsoft recomienda que las llaves se usen de forma coherente para todos los bloques de código de una instrucción if-elseif-else (presentes o quitados de forma coherente).

Quite solo las llaves de un bloque de código cuando haga que el código sea más legible. Siempre es aceptable incluir llaves.

Elimine los avances de línea solo si esto ayuda a que el código sea más legible. Según Microsoft, el código será más legible cuando cada instrucción se coloque en su propia línea de código.
 */
