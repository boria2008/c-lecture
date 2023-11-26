
int[] arr = { 156, 258, 45, 23, 67, 24, 92, 15, 756, 452 };
int i = arr.Length;
Console.WriteLine($"size= {i}");
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} \t");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionArr(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition])
            {
                minPosition = j;
            }
        }

        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }

}
SelectionArr(arr);
PrintArray(arr);

