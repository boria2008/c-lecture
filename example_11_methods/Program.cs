Console.Clear();

void Method1()
{
    Console.WriteLine("@Boris_Razor");
}
// Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Text");

void Method21(string msg, int count)
{
    for (int a = 0; a < count; a++)
    {
        Console.WriteLine(msg);
    }
}
// Method21("Text", 2);
// Method21(count: 2, msg: "NewText");


int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

// Method1();

string Method4(int count, string text)
{
    int i = 0;
    string res = string.Empty;
    while (i < count)
    {
        res = res + text;
        i++;
    }
    return res;
}
string result = Method4(4, "колядьмйх\t");
Console.WriteLine(result);
