// Write a program that, depending on the ordinal number of the day of the week (1, 2, ..., 7), displays its name (Monday, Tuesday, ..., Sunday).

Console.Write("Type a day number: ");
int weekday = Convert.ToInt32(Console.ReadLine());

while (weekday == 0)
{
    Console.Write("Incorrect number: ");
    weekday = Convert.ToInt32(Console.ReadLine());
}

while (weekday >= 8)
{
    Console.Write("Incorrect number. Type a number from 1 to 7: ");
    weekday = Convert.ToInt32(Console.ReadLine());
}
//weekday = Convert.ToInt32(Console.ReadLine()); 

{
    switch (weekday)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thurthday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
    }
}

