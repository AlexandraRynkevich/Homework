// Enter a string from the console and output each character on a new line
Console.WriteLine("Enter:");
String userInput = Console.ReadLine();

for (int i = 0; i < userInput.Length; i++)
{
    Console.WriteLine(userInput[i]);
}