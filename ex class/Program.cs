void IESort(IEnumerable<int> arr)
{
    int[] arry = arr.ToArray();
    QuickSort(arry, 0, (arry.Length) - 1);
    IEnumerable<int> array = arry;
    int j = 0;
    foreach (int i in array)
    {
        if (i < 100)
            Console.Write($"0{i}");
        else
            Console.Write($"{i}");
        if (j % 2 == 0)
            Console.Write("\t");
        else
            Console.Write("\n");
        j++;
    }
    return;
}
void QuickSort(int[] arr ,int begin ,int end)
{
    if (begin >= end) return;
    int priver = QuickSort_one(arr, begin, end);
    QuickSort(arr, priver + 1, end);
    QuickSort(arr, begin, priver-1);
}
int QuickSort_one(int[] arr,int begin ,int end)
{
    int i = begin;
    int j = end;
    int p = arr[i];
    while (i < j)
    {
        while (arr[j]>=p && i < j)
        {
            j--;
        }
        arr[i] = arr[j];
        while (arr[i]<=p && i < j)
        {
            i++;
        }
        arr[j] = arr[i];
    }
    arr[i] = p;
    return i;
}
IEnumerable<int> arr =new[] { 652, 726, 563, 456, 132, 94, 531, 391, 96, 74, 84, 54, 55, 32, 43 };
IESort(arr);