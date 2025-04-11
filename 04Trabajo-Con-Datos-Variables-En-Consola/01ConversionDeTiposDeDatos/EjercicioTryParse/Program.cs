/* string[] values = { "12,3", "45", "ABC", "11", "DEF" };
string message = "";
decimal total = 0;
decimal parserDec= 0;
foreach (var value in values){
    if(decimal.TryParse(value, out parserDec)){
        total += (decimal)parserDec;
    }else{
        message += value;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
 */

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = 0;
decimal result2 = 0;
float result3 = 0;





// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
parseToInt();
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
parseToDecimal();
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
parseToFloat();
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


void parseToInt() 
{
    result1 = value1 / (int)value2;
}

void parseToDecimal(){
    result2 = value2 / (decimal)value3;
}

void parseToFloat(){
    result3 = value3 / (float)value1;
}