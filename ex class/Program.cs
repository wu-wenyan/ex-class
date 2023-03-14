void IESort(IEnumerable<int> arr)
{
    int[] arry = arr.ToArray(); //轉換為一般陣列去快排
    QuickSort(arry, 0, (arry.Length) - 1);  //呼叫快排
    IEnumerable<int> array = arry;  //轉回IEnumerable
    int j = 0;  
    foreach (int i in array)    //格式化輸出整理
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
void QuickSort(int[] arr ,int begin ,int end)   //快排1
{
    if (begin >= end) return;   //判斷index
    int priver = QuickSort_one(arr, begin, end);
    QuickSort(arr, priver + 1, end);    //左~
    QuickSort(arr, begin, priver-1);    //右~
}
int QuickSort_one(int[] arr,int begin ,int end)
{
    int i = begin;
    int j = end;
    int p = arr[i];
    while (i < j)
    {
        while (arr[j]>=p && i < j)
            j--;
        arr[i] = arr[j];
        while (arr[i] <= p && i < j)
            i++;
        arr[j] = arr[i];
    }
    arr[i] = p;
    return i;
}
IEnumerable<int> arr =new[] { 652, 726, 563, 456, 132, 94, 531, 391, 96, 74, 84, 54, 55, 32, 43 };  //預設數字集合
IESort(arr);  //呼叫整理集合