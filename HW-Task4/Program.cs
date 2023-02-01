
using System;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Enter your number:");
string yourNumber = Console.ReadLine();
char [] num;
int sum = 0;
int product = 1;

num = yourNumber.ToCharArray(0, 3);
Console.WriteLine($"units: {num[yourNumber.Length-1]}");
Console.WriteLine($"tens: {num[yourNumber.Length-2]}");

for (int i = 0; i < num.Length; i++)
{                                             
    sum = sum + (int)Char.GetNumericValue(num[i]);
    product = product * (int)Char.GetNumericValue(num[i]);    
}
Console.WriteLine("sum: " + sum);
Console.WriteLine("product: " + product);


for (int a = 0; a < num.Length - 1; a++)
{
    for (int b = a + 1; b < num.Length; b++)
    {
        int tempNumber = num[a];
        num[a] = num[b];
        num[b] = (char)tempNumber;
    }
}

Console.WriteLine("reverse:");
PrintArray(num);

Console.WriteLine("");
for (int i = 0; i < num.Length; i++)
{
    int tempNumber = num[0];
    int tempNumber2 = num[num.Length - 1];
    num[0] = (char)tempNumber2;
    num[num.Length - 1] = (char)tempNumber;
}
Console.WriteLine("reverse 1st and last:");
PrintArray(num);



void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}