Console.Clear();
int Max(int A, int B, int C)
{
    int result = A;
    if (B > result) result = B;
    if (C > result) result = C;
    return result;
}
int[] array = {14, 23, 65, 23, 95, 45, 755, 0, 4};
int i=0;
while (i<array.Length) 
{
    Console.Write($"{array[i]}\t");
    i++;
}
// Console.WriteLine($"{array[0]} {array[1]} {array[2]} {array[3]} {array[4]} {array[5]} {array[6]} {array[7]} {array[8]}");
Console.WriteLine("");
int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);
int max = Max(max1, max2, max3);
Console.WriteLine($"Максимальное из чисел = {max}");


