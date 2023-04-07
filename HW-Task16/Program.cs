// Print numbers in the form of the following table:
//a) 5
//    5 5
//    5 5 5
//    5 5 5 5
//    5 5 5 5 5

//   10
//   20 20
//   30 30 30
//   40 40 40 40
//   50 50 50 50 50

const int limit = 7;
for (int i = 1; i <= limit; i++)
{
    Print(limit, i);
}

for (int i = limit; i > 0; i--)
{
    Print(1, i);
}

for (int i = 0; i <= limit; i++)
{
    Print(limit * 2 * i, i);
}

void Print(int x, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(x + " ");
    }
    Console.WriteLine();
}

for (int i = limit; i > 0; i--)
{
    Print((limit - i + 1) * limit, i);
}