/* La instrucción do-while ejecuta una instrucción o un bloque de instrucciones mientras que una expresión booleana especificada se evalúa como true.
 Como esa expresión se evalúa después de cada ejecución del bucle, un bucle do-while se ejecuta una o varias veces. 
 
 do
{
    // This code executes at least one time
} while (true);
 */
/* 
 Random random = new Random();

int die = 0;
 do{
    die = random.Next(1,10);
    Console.WriteLine(die);
 } while (die != 7); 
 */

/*  Random random = new Random();

int die = 0;

while(die != 7){
    die = random.Next(1,10);
    Console.WriteLine(die);
} */

/* En algunos casos, el objetivo será cortocircuitar el resto del código dentro del bloque y continuar a la iteración siguiente. Eso se puede hacer con la instrucción continue.

a instrucción continue transfiere la ejecución al final de la iteración actual. Este comportamiento es diferente del comportamiento que vimos con la instrucción break.
La instrucción break finaliza la iteración (o switch) y transfiere el control a la instrucción que sigue a la instrucción terminada.
Si no hay ninguna instrucción después de la instrucción terminada, el control se transfiere al final del archivo o método.


Random random = new Random();

int current = random.Next(1,10);
do{
    current = random.Next(1,10);
    if(current > 8)
        continue;
    Console.WriteLine(current);
}while(current!= 7);*/


/* 
Desafío de código: escribir código para implementar las reglas de juego
Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:

    -Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
    -El héroe y el monstruo comenzarán con 10 puntos de salud.
    -Todos los ataques tendrán un valor comprendido entre 1 y 10.
    -El héroe ataca primero.
    -Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
    -Si la salud del monstruo es mayor que 0, puede atacar al héroe.
    -Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
    -Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
    -Imprima el ganador.

1.-Asegúrese de que tiene un archivo Program.cs vacío abierto en Visual Studio Code.

Si es necesario, abra Visual Studio Code y, luego, lleve a cabo los pasos siguientes para preparar un archivo Program.cs en el editor:

    a)En el menú Archivo, seleccione Abrir carpeta.

    b)Use el cuadro de diálogo "Abrir carpeta" para ir a la carpeta CsharpProjects.

    c)En el panel EXPLORADOR de Visual Studio Code, seleccione Program.cs.

    d)En el menú Selección de Visual Studio Code, elija Seleccionar todo y presione la tecla Supr.

2.-Escribe el código del juego que implementa cada regla.

3.-Ejecute la aplicación y compruebe que la salida cumple los requisitos.

4.-Con independencia de cómo lo haga, el código debe generar una salida similar a esta:



Copiar
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins! 

int hero = 10;
int monster = 10;

int damage = 0;

Random die = new Random();

Console.WriteLine("Welcome hero, what's your name?");

string heroName = Console.ReadLine(); 

Console.WriteLine("The battle starts now! press enter to begin");

Console.ReadLine();
do{
    damage = die.Next(1,10);
    Console.WriteLine($"{heroName} attacks! it deals {damage} points of damage");
    monster -= damage; 
    if (monster < 0) monster =0;
    Console.WriteLine($"The monster has {monster} hp left");

    if(monster>0){
        damage = die.Next(1,10);
        Console.WriteLine($"The monster retaliates with {damage} points of damage!");
        hero -= damage;
        if(hero < 0) hero = 0;
        Console.WriteLine($"{heroName} has {hero} hp left");
    }
} while(monster > 0 && hero >0);

if(monster<=0){
    Console.WriteLine($"Congratulations {heroName}, you win!");
}else{
    Console.WriteLine("You have failed in your quest");
}*/



/* 
Proyecto de código 1: escritura de código que valida la entrada de enteros
Estas son las condiciones que el primer proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración: la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor de enteros entre 5 y 10.

Dentro del bloque de iteración:

-La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
-La solución debe asegurarse de que la entrada es una representación válida de un entero.
-Si el valor del entero no está comprendido entre 5 y 10, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor del entero entre 5 y 10.
-La solución debe garantizar que el valor de enteros está comprendido entre 5 y 10 antes de salir de la iteración.
-Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.


 1.-Escriba el código que implementa cada condición para el proyecto de código 1.

 2.-Ejecute la aplicación y compruebe que el código valida la entrada de usuario en función de los requisitos especificados.

 3.-Por ejemplo, al ejecutar la aplicación, debe rechazar valores de entrada como "two" y "2", pero debe aceptar un valor de entrada de "7".

 4.-En el ejemplo descrito anteriormente, la salida de la consola debe ser similar a la siguiente:

Output

Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted. 


string value = "";
bool isInt = false;
int intValue = 0;
do{
    Console.WriteLine("Por favor, inserte un valor entre el 5 y el 10");

    value = Console.ReadLine();

    isInt = int.TryParse(value, out intValue);

    if(!isInt)
        Console.WriteLine($"Ha insertado {value}, por favor, inserte un valor válido");
    else if(intValue < 5 || intValue > 10)
        Console.WriteLine($"Ha insertado {value},ese número no está entre 5 y 10");

}while(intValue < 5 || intValue > 10 || !isInt);

Console.WriteLine($"Su valor introducido ({value}) ha sido aceptado");*/



/* 
Proyecto de código 2: escritura de código que valida la entrada de cadena
Estas son las condiciones que el segundo proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración, la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario uno de los tres nombres de rol: Administrador, Director o Usuario.

Dentro del bloque de iteración:

- La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
- La solución debe garantizar que el valor especificado coincide con una de las tres opciones de rol.
- La solución debe usar el método Trim() en el valor de entrada para omitir los caracteres de espacio iniciales y finales.
- La solución debe usar el método ToLower() en el valor de entrada para omitir el caso.
- Si el valor especificado no coincide con una de las opciones de rol, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario una entrada válida.
- Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.

1.- Marcar como comentario todo el código en el panel editor de Visual Studio Code

    a) Selección de todas las líneas de código en el editor de código
    b) En el menú Edición, seleccione Alternar comentario de bloque.


2.- Ejecute la aplicación y compruebe que el código valida la entrada de usuario en función de los requisitos especificados.

    Por ejemplo, al ejecutar la aplicación, debe rechazar valores de entrada como "Admin", pero debe aceptar un valor de entrada de "administrator".

    La salida de la consola de este ejemplo debe ser similar a la siguiente:

Output///////////////////////////////////////////////


Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
 

 bool validated = false;

string input = "";

 while(!validated){

    Console.WriteLine("Enter your role name (Administrator, Manager or User)");

    input = Console.ReadLine();
    
    switch (input.Trim().ToLower()){
        case "administrator":
            validated = true;
            Console.WriteLine($"Your input value ({input}) has been accepted");
            break;
        case "manager":
            validated = true;
            Console.WriteLine($"Your input value ({input}) has been accepted");
            break;
        case "user":
            validated = true;
            Console.WriteLine($"Your input value ({input}) has been accepted");
            break;
        default:
            Console.Write($"The role you have entered \"{input}\" is not valid. ");
            break;

    }
 }*/

/* 
Proyecto de código 3: escritura de código que procesa el contenido de una matriz de cadenas
Estas son las condiciones que el tercer proyecto de codificación debe implementar:

La solución debe usar la siguiente matriz de cadenas para representar la entrada en la lógica de codificación:



string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };


-La solución debe declarar una variable de enteros denominada periodLocation que se pueda usar para contener la ubicación del carácter de punto dentro de una cadena.

-La solución debe incluir un bucle externo foreach o for que se pueda usar para procesar cada elemento de cadena de la matriz. La variable de cadena que procesará dentro de los bucles debe denominarse myString.

-En el bucle externo, la solución debe usar el método IndexOf() de la clase String para obtener la ubicación del primer carácter de punto de la variable myString. La llamada al método debe ser similar a myString.IndexOf("."). Si no hay ningún carácter de punto en la cadena, se devolverá un valor de -1.

-La solución debe incluir un bucle interno do-while o while que se pueda usar para procesar la variable myString.

-En el bucle interno, la solución debe extraer y mostrar (escribir en la consola) cada frase contenida en cada una de las cadenas que se procesan.

-En el bucle interno, la solución no debe mostrar el carácter de punto.

-En el bucle interno, la solución debe usar los métodos Remove(), Substring() y TrimStart() para procesar la información de cadena.



Ejecute la aplicación y compruebe que la salida cumple los requisitos.

Si la lógica de código funciona correctamente, la salida debe ser similar a la siguiente:

Output

I like pizza
I like roast chicken
I like salad
I like all three of the menu choices

 

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;
string myString = "";

foreach (string oneString in myStrings)
{

    if (oneString.IndexOf(".") != -1)
    {
        myString = oneString;

        while (myString.IndexOf(".") != -1)
        {
            periodLocation = myString.IndexOf(".");
            Console.WriteLine(myString.Substring(0, periodLocation));
            myString = myString.Substring(periodLocation + 1).TrimStart();
        }
    }
    else
    {
        Console.WriteLine(oneString);
    }

}

*/