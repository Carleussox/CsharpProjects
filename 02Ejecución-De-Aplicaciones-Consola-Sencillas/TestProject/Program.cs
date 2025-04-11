/* Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}"); */
/* int firstValue = 500;
int secondValue = 600;
int largerValue= Math.Max(secondValue,firstValue);

Console.WriteLine(largerValue); */
/* Random dice = new Random();

int roll1 =  dice.Next(1,7) ;
int roll2 =  dice.Next(1,7) ;
int roll3 =  dice.Next(1,7) ;

int total = roll1 + roll2 + roll3;
int bonus=0;


if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("You rolled a triple! +6 points");
    bonus += 6;
}
else
{
    if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
    {
        Console.WriteLine("You rolled a double! +2 points");
        bonus += 2;
    }
}
total+= bonus;
Console.WriteLine($"dice roll: {roll1}+{roll2}+{roll3} +bonus({bonus}) = {total}");

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("You Lose");
}
 */
//IFS, ELSE IF'S Y SWITCHS
Random random = new Random();
int daysUntilExpiration =  random.Next(12) ;
int discountPercentage = 0;
string message = "";

switch (daysUntilExpiration)
{
    case 0:
        message = "Your subscription has expired.";
        break;

    case 1:
        discountPercentage = 20;
        message = $"Your subscription expires within a day! \n Renew now and save {discountPercentage}%!";
        break;

    case 2:
    case 3:
    case 4:
    case 5:
        discountPercentage = 10;
        message = $"Your subscription expires in {daysUntilExpiration} days \nrenew now and save {discountPercentage}%!";
        break;

    default:
        message = "Your subscription will expire soon. Renew now!";
        break;

}

Console.WriteLine(message);