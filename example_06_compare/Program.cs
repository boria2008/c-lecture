// Здесь мы создадим программу, которая будет запрашивать у пользователя 
// ввести целые числа, затем сравнит их и выведет на консоли наибольшее и наименьшее.
Console.WriteLine("enter an integer №1");
int number_01=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter an integer №2");
int number_02=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter an integer №3");
int number_03=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter an integer №4");
int number_04=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter an integer №5");
int number_05=Convert.ToInt32(Console.ReadLine());
int min=number_01;
int max=number_02;
if(number_01>number_02) 
{
    int A=number_02;
    max=number_01;
    min=A;
}
Console.WriteLine(max);
Console.WriteLine(min);