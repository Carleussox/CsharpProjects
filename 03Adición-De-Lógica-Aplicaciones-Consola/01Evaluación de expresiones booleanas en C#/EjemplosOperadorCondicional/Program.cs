/* 
El operador condicional sigue esta lógica:
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
 */

/* int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine(discount);

 */
/* Se puede simplificar aún más */

int saleAmount = 1001;
Console.WriteLine($"Discount is {(saleAmount> 1000 ? 100: 50)} %");