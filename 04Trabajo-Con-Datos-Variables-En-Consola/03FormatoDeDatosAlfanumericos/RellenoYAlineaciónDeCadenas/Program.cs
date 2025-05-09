/* RELLENO Y ALINEACIÓN DE CADENAS */
/* El método string.Format() se usa para realizar formatos compuestos, como por ejemplo:

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

La clase string, tiene varios métodos reservados para el formateo de cadenas, algunos de ellos son:

- Métodos que agregan espacios en blanco para fines de formato (PadLeft(), PadRight())
- Métodos que comparan dos cadenas o facilitan la comparación (Trim(), TrimStart(), TrimEnd(), GetHashcode(), la propiedad Length)
- Métodos que ayudan a determinar lo que está dentro de una cadena, o incluso a recuperar solo una parte de la cadena (Contains(), StartsWith(), EndsWith(), Substring())
- Métodos que cambian el contenido de la cadena mediante el reemplazo, la inserción o la eliminación de elementos (Replace(), Insert(), Remove())
- Métodos que convierten una cadena en una matriz de cadenas o caracteres (Split(), ToCharArray())
 */


 /*- APLICACIÓN DEL FORMATO A CADENAS MEDIANTE LA ADICIÓN DE ESPACIO EN BLANCO ANTES O DESPUÉS (Métodos Pad)*/

 /* El método PadLeft() agrega espacios en blanco al lado izquierdo de la cadena para que el número total de caracteres sea igual al argumento que se envía.
  En el ejemplo siguiente, el objetivo es que la longitud total de la cadena sea de 12 caracteres: 
  
 string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));

  */
 /* -RESULTADO:
"    Pad this"
  */
/* Si por el contrario, quisiéramos rellenar una cadena desde la derecha hasta que alcanzase los 12 caracteres, usaríamos .PadRight(12):

 string input = "Pad this";
 Console.WriteLine(input.PadRight(12)+"End of sentence");
 */

 /* -RESULTADO:
 "Pad this    End of sentence"
  */

/* Los métodos pad están sobrecargados, como tal, si incluimos un carácter después del número de caracteres, se rellenará el espacio restante con ese carácter: 


 string input = "Pad this";
 Console.WriteLine(input.PadLeft(12, 'O'));
 Console.WriteLine(input.PadRight(12, '-'));
*/

 /* RESULTADO:
 OOOOPad this
Pad this----
  */

/* Resumiendo:

- El tipo de datos string, las cadenas literales y las variables de tipo String implementan muchos métodos auxiliares para dar formato, modificar y realizar otras operaciones en las cadenas.
- Los métodos PadLeft() y PadRight() agregan espacio en blanco (u, opcionalmente, otro carácter) a la longitud total de una cadena.
- Se usa PadLeft() para alinear una cadena a la derecha.
- Algunos métodos están sobrecargados, lo que significa que tienen varias versiones del método con otros argumentos que afectan a su funcionalidad.
- El operador += concatena una nueva cadena a la derecha a la cadena existente de la izquierda.
 */

  /*////////// EJERCICIO: USO DE CADENAS CON RELLENO/////////// */

/* Imagine que trabaja para una empresa de procesamiento de pagos que todavía admite sistemas centrales heredados.
  A menudo, esos sistemas requieren que los datos se escriban en columnas específicas.
  Por ejemplo, almacene el identificador del pago en las columnas 1 a 6, el nombre del beneficiario en las columnas 7 a 30, y el importe del pago en las columnas 31 a 40.
  Además, lo más importante es que el importe del pago se debe alinear a la derecha.
  Se le ha pedido que cree una aplicación que convierta los datos del sistema de administración de bases de datos relacionales al formato de archivo heredado.
  Para asegurarse de que la integración funciona correctamente, el primer paso es confirmar el formato de archivo y proporcionar una muestra de la salida a los encargados del mantenimiento
  del sistema heredado. Más adelante, se basará en este trabajo para enviar cientos o miles de pagos para procesarlos a través de un archivo de texto ASCII.
  Debido a la dificultad de contar las columnas exactas donde aparece cada elemento de datos, se agregará una línea directamente encima de la salida para facilitar el recuento de las columnas:
  1234567890123456789012345678901234567890
   */
//Parámetros iniciales:
 string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";
//Fin de parámetros iniciales
 string formattedLine = paymentId.PadRight(6)+ payeeName.PadRight(24)+ paymentAmount.PadRight(10);
 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);




 /* Resultado esperado: 
  1234567890123456789012345678901234567890
  769C  Mr. Stephen Ortega       $5,000.00 */