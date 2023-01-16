// Write a program to calculate the function x=12a2+7a+12. The parameter «a» is entered by the user. Provides validation of user input.

Console.WriteLine("x=12*(a*a)+7a+12");
string input = ReadUserInput(string.Empty);

double a;

while (!double.TryParse(input, out a))
{
    input = ReadUserInput("This is not a number!");
}

double x = 12 * (a * a) + 7 * a + 12;
Console.WriteLine($"x={x}");

string ReadUserInput(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Enter a=");
    string input = Console.ReadLine();
    return input;
}

