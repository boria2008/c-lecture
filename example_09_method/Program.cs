int Max(int A, int B, int C)
{
    int result = A;
    if (B > result) result = B;
    if (C > result) result = C;
    return result;
}
int a1 = new Random().Next(-1000, 1001);
int b1 = new Random().Next(-1000, 1001);
int c1 = new Random().Next(-1000, 1001);
int a2 = new Random().Next(-1000, 1001);
int b2 = new Random().Next(-1000, 1001);
int c2 = new Random().Next(-1000, 1001);
int a3 = new Random().Next(-1000, 1001);
int b3 = new Random().Next(-1000, 1001);
int c3 = new Random().Next(-1000, 1001);

Console.WriteLine($"{a1} {b1} {c1} {a2} {b2} {c2} {a3} {b3} {c3}");

int max1=Max(a1,b1,c1);
int max2=Max(a2,b2,c2);
int max3=Max(a3,b3,c3);
int max=Max(max1,max2,max3);
Console.WriteLine($"Максимальное из чисел = {max}");
