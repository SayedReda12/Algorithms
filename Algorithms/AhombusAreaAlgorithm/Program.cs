// See https://aka.ms/new-console-template for more information
Console.WriteLine(RhombusArea(6,4));
Console.WriteLine(RhombusArea(9,6));
Console.WriteLine(RhombusArea(15,10));

/// <summary>
/// length (l),
/// heigth (h)
/// </summary>
double RhombusArea(double l, double h)
{
    var a = l * h;
    return a;
}