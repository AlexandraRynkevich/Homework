//Given the radius of a circle and the side of a square. Which shape has more area?
// S = π × r2
// S = a × a = a2

double radius = 2;
double side = 2;
double circle = radius * radius * Math.PI;
double square = side * side;
if (circle > square)
    Console.WriteLine(" Circle " + "(" + circle + ")" + " has more area than " + " Square " + "(" + square + ")");
else
{
    if (circle < square)
        Console.WriteLine(" Square " + "(" + circle + ")" + " has more area than " + " Circle " + "(" + square + ")");
    else
        Console.WriteLine(" Circle " + "(" + circle + ")" + " is equal to " + " Square " + "(" + square + ")");
}

