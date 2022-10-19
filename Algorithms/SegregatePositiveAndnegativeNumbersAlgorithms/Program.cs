// See https://aka.ms/new-console-template for more information

var array = new int[] {2, -1, 3, 5, -4, -6,9,-9,8,-2,4,-3};

Console.WriteLine(string.Join(", ",array));
//SegregatNubmers(array);
SegregateNegativeNumberAnotherSolution(array);
Console.WriteLine(string.Join(", ", SegregateNegativeNumberAnotherSolution(array)));



#region Divide and conqur (merge sort) solution

void SegregatNubmers(int[] array)
{
    if (array.Length <= 1) return;
    var mid = array.Length / 2;

    var leftArray = new int[mid];
    var rightArray = new int[array.Length - mid];
    for (int i = 0; i < leftArray.Length; i++)
    {
        leftArray[i] = array[i];
    }

    for (int j = 0; j < rightArray.Length; j++)
    {
        rightArray[j] = array[mid + j];
    }

    SegregatNubmers(leftArray);
    SegregatNubmers(rightArray);

    Megre(leftArray, rightArray, array);

}

void Megre(int[] leftArray, int[] rightArray, int[] array)
{
    int i = 0, j = 0, k = 0;

    while (i < leftArray.Length && j < rightArray.Length)
    {
        if (leftArray[i] < 0)
        {
            array[k] = leftArray[i];
            i++;
        }
        else if (rightArray[j] < 0)
        {
            array[k] = rightArray[j];
            j++;
        }
        else
        {
            break;
        }

        k++;
    }

    while (i < leftArray.Length)
    {
        array[k] = leftArray[i];
        i++;
        k++;
    }

    while (j < rightArray.Length)
    {
        array[k] = rightArray[j];
        j++;
        k++;
    }
}

#endregion


int[] SegregateNegativeNumberAnotherSolution(int[] array)
{
    var left = new List<int>();
    var right = new List<int>();
    foreach (var item in array)
    {
        if (item < 0)
        {
            left.Add(item);
        }
        else
        {
            right.Add(item);
        }
    }

    left.AddRange(right);
    return left.ToArray();
}