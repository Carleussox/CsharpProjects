/* Aquí se usará el método Sort() de la clase Array para ordenar los elementos de la matriz de forma alfanumérica. */
string[] pallets = ["B14", "A11", "B12", "A13"];

/* 
//
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("Reversing pallets: ");
Console.ReadLine();
//

 */
/* Para invertir el orden de los palés mediante el método Array.Reverse() */
/* 
//Array.Reverse(pallets);

foreach(var pallet in pallets){
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("Reversed...."); 
//
*/
Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

