// See https://aka.ms/new-console-template for more information
Console.WriteLine(TrapezoidArea(10,20,7));


// b1 - first base
// b2 - second base
// h - height
double TrapezoidArea(double b1, double b2, double h)
{
    var a = 0.5 * (b1 + b2) * h;
    return a;
}