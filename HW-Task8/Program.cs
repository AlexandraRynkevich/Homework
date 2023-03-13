// Check if the number entered from the keyboard belongs to the interval (-5, 3).
//1 <= x && x <= 100

double bottom = -5;
double top = 3;
string yourNumber = "";
Console.WriteLine("Enter your number:");
yourNumber = Console.ReadLine();
double number = 0;
while (!double.TryParse(yourNumber, out number))
{
    Console.Write("This is not valid input. Please enter an integer value: ");
    yourNumber = Console.ReadLine();
}


if (number >= bottom && number <= top)
    Console.WriteLine("in range");
else
    Console.WriteLine("not in range");