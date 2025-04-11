/* ¿Cómo funciona una instrucción switch?
La instrucción switch elige una sección de código que se va a ejecutar en una lista de posibles secciones switch.
La sección switch seleccionada se elige en función de una coincidencia de patrón con la expresión de coincidencia de la instrucción. 

La expresión match (que también se puede denominar expresión switch) es el valor que sigue a la palabra clave switch.
 Cada sección switch se define mediante un patrón de caso. Los patrones de caso se construyen mediante la palabra clave case seguida de un valor.
Los patrones de caso son expresiones booleanas que se evalúan como true o false. 
  Cada sección switch incluye un pequeño número de líneas de código que se ejecutarán si el patrón de caso es una coincidencia para la expresión match. 


Una instrucción switch debe incluir al menos una sección switch, pero normalmente contendrá tres o más secciones switch.

*/

/* Console.WriteLine("Introduzca su nivel de empleado");

int employeeLevel = int.Parse(Console.ReadLine());
Console.WriteLine("introduzca su nombre");
string employeeName = Console.ReadLine();

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"Bienvenido, {employeeName}, {title}");
 */

/* Actualice el código para usar una instrucción switch en lugar de la construcción if-elseif-else.

Compruebe que la salida no ha cambiado.

Independientemente de cómo lo haga, el código debe generar el siguiente resultado:

Output

Product: Large Maroon Sweat shirt */



/* 
if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
} */



string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";



switch(product[0]){
    case "01":
        type = "Sweat shirt";
            break;
    case "02":
        type = "T-Shirt";
            break;
    case "03":
        type ="Sweat pants";
            break;
    default:
        type = "other";
            break;
}

switch(product[1]){
    case "BL":
        color = "Black";
            break;

    case "MN":
        color = "Maroon";
            break;

    default:
        color = "White";
            break;
    
}



switch(product[2]){
    case "S":
        size = "Small";
            break;
    case "M":
        size = "Medium";
            break;
    case "L":
        size = "Large";
            break;
    default:
        size = "One Size Fits All";
            break;
}



Console.WriteLine($"Product: {size} {color} {type}");