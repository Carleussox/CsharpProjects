/* ///////////////////EJERCICIO:Completar el desafío de aplicar la interpolación de cadenas a una carta de formulario//////////////////////// */
/* El trabajo consiste en escribir código de C# en el que se combinará información personalizada del cliente.
 La carta contendrá información como la cartera existente y comparará los rendimientos actuales con los previstos si invirtieran en el uso de los nuevos productos. 
 RESULTADO ESPERADO:
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00  
 */
 
 ///Parámetros iniciales:
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;
//Fin de parámetros iniciales

// Your logic here


Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:c}.\n");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage =currentProduct.PadRight(20);
comparisonMessage += String.Format($"{currentReturn:P2}").PadRight(10);
comparisonMessage += $"{currentProfit:c}\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format($"{newReturn:P2}").PadRight(10);
comparisonMessage += $"{newProfit:c}";

// Your logic here

Console.WriteLine(comparisonMessage);