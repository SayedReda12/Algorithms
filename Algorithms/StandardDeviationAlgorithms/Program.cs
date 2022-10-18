// See https://aka.ms/new-console-template for more information

Console.Write("n= ");
var n = Int32.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("standard deviation is: " + GetStandardDeviation(n));

// (n)- number of data (length of the array)
double GetStandardDeviation(int n)
{
    var x = new int[n]; 
    double a=0, b=0, avg = 0,sd=0;
    for (int i = 0; i < n; i++)
    {
        Console.Write("x[" + i + "]= ");
        x[i] = Int32.Parse(Console.ReadLine()??"0");
        avg += x[i];
    }

    avg = (avg /n);

    for (int i = 0; i < n; i++)
    {
        a += Math.Pow(x[i] - avg, 2);
    }

    b = a / n;
    sd = Math.Sqrt(b);
    return sd;
}