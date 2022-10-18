// See https://aka.ms/new-console-template for more information

var x = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
Console.WriteLine(BinarySearch(x,2));
Console.WriteLine(BinarySearch(x,7));
Console.WriteLine(BinarySearch(x,0));
Console.WriteLine(BinarySearch(x,10));


int BinarySearch(int[] x, int key)
{
    int low = 0;
    int high = x.Length - 1;
    while (high >= low)
    {
        int mid = (low + high) / 2;
        if (key == x[mid])
        {
            return mid;
        }
        else if (key > x[mid])
            low = mid + 1;
        else
            high = mid - 1;
    }

    return -1;
}