// See https://aka.ms/new-console-template for more information

using System.Dynamic;

Console.Write("n= ");
var n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("standard deviation is: " + GetTheCorrelation(n));


double GetTheCorrelation(int n)
{
    var x = new double[n];
    var y = new double[n];
    double sumOfX = 0,
        sumOfY = 0,
        sumOfXbyY = 0,
        sumOfXsquare = 0,
        sumOfYsquare = 0,
        numerator = 0,
        denominator = 0,
        correlation = 0;

    for (int i = 0; i < n; i++)
    {
        Console.Write("x[" + i + "]= ");
        x[i] = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("y[" + i + "]= ");
        y[i] = int.Parse(Console.ReadLine() ?? "0");

        sumOfX += x[i];
        sumOfY += y[i];
        sumOfXbyY += x[i]* y[i];
        sumOfXsquare += Math.Pow(x[i], 2);
        sumOfYsquare += Math.Pow(y[i], 2);
    }

    numerator = n * sumOfXbyY - sumOfX * sumOfY;
    denominator = Math.Sqrt(n * sumOfXsquare - Math.Pow(sumOfX, 2)) * Math.Sqrt(n * sumOfYsquare - Math.Pow(sumOfY, 2));
    correlation = numerator / denominator;
    
    return correlation;
}