//Given the radius of a circle and the side of a square. Which shape has more area?
// S = π × r2
// S = a × a = a2

double radius = 2;
double side = 22;

double mycircle = CircleArea(radius);
double mysquare = SquareArea(side);

    if (mycircle > mysquare)
        Console.WriteLine("Circle " + "(" + mycircle + ")" + " has more area than " + " Square " + "(" + mysquare + ")");
    else if (mycircle < mysquare)
        Console.WriteLine("Square " + "(" + mysquare + ")" + " has more area than " + " Circle " + "(" + mycircle + ")");
    else
        Console.WriteLine("equal");

     double CircleArea(double x)
    {
        return x * x * Math.PI;
    }

     double SquareArea(double y)
    {
        return y * y;
    }
