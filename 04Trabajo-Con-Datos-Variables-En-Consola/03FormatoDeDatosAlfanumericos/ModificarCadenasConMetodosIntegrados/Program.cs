/*////////////////////Uso de los métodos auxiliares de cadena IndexOf() y Substring()///////////////// */

/* 
IndexOf() proporciona la primera posición de un carácter o una cadena dentro de otra cadena.
IndexOf() devuelve -1 si no encuentra ninguna coincidencia.
Substring() devuelve solo la parte especificada de una cadena, utilizando una posición inicial y una longitud opcional.

A la hora de usar el método substring hay que tener en cuenta cómo funcionan las posicienes de caracteres dentro del string a recortar.
A partir del método IndexOf, somos capaces de obtener la posición inicial de la cadena o carácter que queremos identificar dentro del string,
pero eso no significa que podamos hacer el substring inmediatamente, por ejemplo:

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

string messageInsides = message.Substring(openingPosition,closingPosition-openingPosition);
Console.WriteLine(messageInsides);

Este código nos traerá "(inside the parentheses" de vuelta, precisamente por cómo funcionan las posiciones, tenemos que tener en cuenta que nos señala dónde empieza ese paréntesis, 
no el inicio de su contenido.
*/



/*
Teniendo lo anterior en cuenta, si añadimos éste código encima del substring:

openingPosition ++;

string messageInsides = message.Substring(openingPosition,closingPosition-openingPosition);
Console.WriteLine(messageInsides);


Obtendremos este resultado:

inside the parentheses
 */


/* Pongamos otro ejemplo:


 
string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

//En este caso, como lo que estamos usando para  buscar la posición inicial es una cadena, tenemos que ajustar el resultado para que cree el substring a partir del final de esta cadena
//Sabiendo el número de caracteres de <span> podríamos hacer algo como : openingPosition= openingPosition+"<span>".Length;
openingPosition= openingPosition+"<span>".Length;

message = message.Substring(openingPosition, closingPosition-openingPosition);




Console.WriteLine(message);

  RESULTADO:
between the tags
*/
/* Lo ideal sería evitar los llamados valores mágicos, en su lugar, haremos constantes de esos valores: */

/* string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition= openingPosition+"<span>".Length;

message = message.Substring(openingPosition, closingPosition-openingPosition);




Console.WriteLine(message);


RESULTADO:
between the tags */


/* //////////////////////////Uso de los métodos auxiliares IndexOf() y LastIndexOf() de String/////////////////////////////// */

/* Como acabamos de repasar, el método .IndexOf() devuelve el índice de la primera aparición de un carácter o subcadena especificados dentro de una cadena determinada.
El método .LastIndexOf() devuelve la posición del índice de la última aparición de un carácter o cadena dentro de una cadena determinada.
 Los métodos Indexof() y LastIndexOf() devuelven -1 si no se encuentra el carácter o la cadena. 
 Pongamos un ejemplo: 

 string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

RESULTADO:
For the message: 'hello there!', the first 'h' is at position 0 and the last 'h' is at position 7.

 */

/* 
Este método puede resultar útil si queremos hallar la última cadena o carácter que se repitan dentro de otra cadena, por ejemplo: 

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

RESULTADO:
set of parentheses
*/



/* Y si, por el contrario, quisiéramos obtener TODAS las cadenas entre paréntesis del siguiente mensaje? */

string message = "(What if) there are (more than) one (set of parentheses)?";

bool positionNotFound = true;
int openingPosition = 0;
int closingPosition = 0;
openingPosition = message.IndexOf("(");

while (positionNotFound)
{

    openingPosition += 1;
    closingPosition = message.IndexOf(")");
    Console.WriteLine(message.Substring(openingPosition, closingPosition - openingPosition));

    message = message.Substring(closingPosition + 1);
    openingPosition = message.IndexOf("(");
    if (openingPosition == -1) { positionNotFound = false; }

}
