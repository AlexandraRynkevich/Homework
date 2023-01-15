// Write a program to calculate the function x=12a2+7a+12. The parameter «a» is entered by the user. Provides validation of user input.
using System.Security.Cryptography;
using System.Xml.Linq;

Console.WriteLine("x=12*(a*a)+7a+12");
Console.WriteLine("Enter a=");
string input = Console.ReadLine();

int a;

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Value can't be empty! Enter a=");
    input = Console.ReadLine();
}
while (!int.TryParse(input, out a))
{
    Console.WriteLine("This is not a number! Enter a=");
    input = Console.ReadLine();
}
a = Convert.ToInt32(input);
int x = 12 * (a * a) + 7 * a + 12;
Console.WriteLine($"x={x}");

