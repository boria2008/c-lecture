using System.Security.Cryptography.X509Certificates;

Console.Clear();
// Графическая программа
// Console.SetCursorPosition(Ax,Ay);
// Console.WriteLine("+");

Console.WriteLine("Введите значение абциссы первой точки");
int Ax=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение ординаты первой точки");
int Ay=Convert.ToInt32(Console.ReadLine());

Console.SetCursorPosition(Ax,Ay);
Console.WriteLine("*");

Console.WriteLine("Введите значение абциссы второй точки");
int Bx=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение ординаты второй точки");
int By=Convert.ToInt32(Console.ReadLine());

Console.SetCursorPosition(Bx,By);
Console.WriteLine("*");

Console.WriteLine("Введите значение абциссы третьей точки");
int Cx=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение ординаты третьей точки");
int Cy=Convert.ToInt32(Console.ReadLine());

Console.SetCursorPosition(Cx,Cy);
Console.WriteLine("*");

int x=Ax,y=Ay; // Первая точка отрезка
int count=0;
while(count<100)
{
    int F=new Random().Next(0,3); // Произвольный выбор номера второй точки отрезка
    if(F==0)
    {
        x=(x+Ax)/2; // Присваивание координат в зависимости от случайного выбора второй точки отрезка
        y=(y+Ay)/2; // Присваивание координат в зависимости от случайного выбора второй точки отрезка
    }
    if(F==1)
    {
        x=(x+Bx)/2;// Присваивание координат в зависимости от случайного выбора второй точки отрезка
        y=(y+By)/2;// Присваивание координат в зависимости от случайного выбора второй точки отрезка
    }
    if(F==2)
    {
        x=(x+Cx)/2;// Присваивание координат в зависимости от случайного выбора второй точки отрезка
        y=(y+Cy)/2;// Присваивание координат в зависимости от случайного выбора второй точки отрезка
    }
    {
        Console.SetCursorPosition(x,y);
        Console.WriteLine("*");
        count++;
    }
}
