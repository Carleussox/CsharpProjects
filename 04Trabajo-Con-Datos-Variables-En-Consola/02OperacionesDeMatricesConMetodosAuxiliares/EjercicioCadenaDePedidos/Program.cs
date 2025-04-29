/* Ejercicio: Desafío para analizar una cadena de pedidos, ordenar los pedidos y etiquetar posibles errores

- En este desafío, tiene que analizar los "identificadores de pedido" individuales y generar los "OrderIDs" ordenados y etiquetados como "Error" si no tienen exactamente cuatro caracteres de longitud.
- La variable orderStream contiene string de varios id. de pedido separados por comas.
- El código debe analizar los "Id. de pedido" de string de los pedidos entrantes y almacenar los "Id. de pedido" en una matriz.
- El código debe hacer que cada "Id. de pedido" ordenado por prioridad y por etiqueta que no tenga exactamente cuatro caracteres de longitud genere "- Error".
- Este código debe producir la salida siguiente:

        A345
        B123
        B177
        B179
        C15     - Error
        C234
        C235
        G3003   - Error
 */

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";


string[] arrayOrders = orderStream.Split(",");

Array.Sort(arrayOrders);

int pedidosCorrectos = checkValidOrders(arrayOrders);
string[] validOrders = new string[pedidosCorrectos];

int ordertracker = 0;

foreach(string order in arrayOrders){
    if(order.Length == 4){
        validOrders[ordertracker] = order;
        Console.WriteLine(order);
    }else{
        Console.WriteLine($"{order} \t- Error");
    }
}



int checkValidOrders(string[] orders)
{   
    int pedidosCorrectos = 0;

    
    foreach (string order in orders)
    {
        if (order.Length == 4)
        {
            pedidosCorrectos++;
        }
    }
    return pedidosCorrectos;
}

