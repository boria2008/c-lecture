// Программа которая запрашивает число и выводит на экран последовательность 
// от отрицательного значения этого числа до него.
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2
// Console.Clear();

// Console.WriteLine("Введите целое число");
// int A = Convert.ToInt32(Console.ReadLine());
// int negativA = A * -1;
// if (A > 0)
// {
//     while (negativA <= A)
//     {
//         Console.Write(negativA + ",");
//         negativA++;
//     }
// }
// if (A < 0)
//     negativA = A;
// A = A * -1;
// {

//     while (negativA <= A)
//     {
//         Console.Write(negativA + ",");
//         negativA++;
//     }
// }
Console.Clear();

Console.WriteLine("Введите целое число");
int A = Convert.ToInt32(Console.ReadLine());
if (A <0) A=-A;
int negativA = A * -1;

while (negativA <= A)
{
    Console.Write(negativA + ",");
    negativA++;
}

