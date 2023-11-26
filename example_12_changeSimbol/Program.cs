


string ReplaceSimbol(string text, char oldSimbol, char newSimbol)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldSimbol) result = result + newSimbol;
        else
        {
            result = result + text[i];
        }
    }
    return result;
}
string text = "мороз и солнце, день чудесный";
string NewText = ReplaceSimbol(text, ' ', '|');
Console.WriteLine(NewText);

NewText = ReplaceSimbol(NewText, 'о', 'О');
Console.WriteLine(NewText);

