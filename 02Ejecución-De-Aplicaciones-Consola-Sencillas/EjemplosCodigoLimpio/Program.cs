// Example 1:

/* Console
.
WriteLine
(
"Hello Example 1!"
)
; */



Console.WriteLine("Hello Example 1!");

// Example 2:

/* string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!"); */

string firstWord = "Hello";
string lastWord = "Example 2";

Console.WriteLine(firstWord + " " + lastWord + "!");


// Example 3:
/* Espacios en blanco y tabulaciones */


/* Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
} */


Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{

    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;

    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// Example 4
///////////////////DESAFIO DE LEGIBILIDAD


/* The Following code inverts the string and measures how many times the character
"o" appears in it
 */

string sentence = "The quick brown fox jumps over the lazy dog.";


char[] charMessage = sentence.ToCharArray();

Array.Reverse(charMessage);
int oNumber = 0;

// iteration to count the o's
foreach (char i in charMessage)
{
    if (i == 'o')
    {
        oNumber++;
    }
}

// convert it back to a string
string new_message = new String(charMessage);



Console.WriteLine(new_message);
Console.WriteLine($"The 'o' has appeared {oNumber} times.");