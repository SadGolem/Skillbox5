
/*static string[] SplitText(string text)
{
    string[] mas = text.Split();
    return OutputText(mas);
}
*/
static string[] OutputText(string[] text)
{
    for (int i = 0; i < text.Length; i++)
    {
        string output = text[i];
        Console.WriteLine(output);
    }
    return text;
}


/*Console.WriteLine("Напишите предложение:");
SplitText(Console.ReadLine());*/

/*-----------------------------------Task2------------------------------------ -*/

Console.WriteLine("Напишите предложение:");
ReversWords(Console.ReadLine());


static string[] SplitText(string text)
{
    string[] mas = text.Split();
    return mas;
}

static string[] ReversWords(string inputPhrase)
{
    string[] mas = SplitText(inputPhrase);
    string[] masReverse = new string[mas.Length];
    for (int i = 0; i < mas.Length; i++)
    {
        masReverse[i] += mas[mas.Length - 1 - i];
    }
    return OutputText(masReverse);
}

