/* 
-   EJERCICIO: EXPLORACIÓN DE LA INTERPOLACIÓN DE CADENAS
*/

/* 
Debe crear el código para imprimir un recibo para que el cliente adquiera participaciones de un producto de inversión. Las participaciones se adquieren
automáticamente al final del año en función de una serie de deducciones en la nómina, por lo que el número de participaciones adquiridas normalmente contiene un importe decimal.
Para imprimir el recibo, es probable que sea necesario combinar de forma precisa datos de tipos diferentes, incluidos valores fraccionarios, de moneda y porcentajes. 
 
 
 
 
 */

 /* Base de código: */

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
/* Fin de base de código */
Console.WriteLine($"Shares: {productShares:n3} Product");
Console.WriteLine($"Sub total: {subtotal:c}");
Console.WriteLine($"Tax: {taxPercentage:p3}");
Console.WriteLine($"Total Billed: {total:c}");





/* Resultado esperado:
Invoice Number: 1201
   Shares: 25.457 Product
     Sub Total: $2,750.00
           Tax: 15.83%
     Total Billed: $3,185.19

 */