// этот вариант из гугла мне, конечно, больше приглняулся =)))
int a = 3;
int b = 33;

Console.WriteLine($"{a}-{b}");

(a, b) = (b, a); 

Console.WriteLine($"{a}-{b}");