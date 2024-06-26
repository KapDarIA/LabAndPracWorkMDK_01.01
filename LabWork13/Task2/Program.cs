using System.Text.RegularExpressions;
using System.Text;

Console.Write("Введите строку:");
string text = Console.ReadLine();
Regex regex = new Regex(@"\s+");
text = regex.Replace(text, @" ").Trim();
Console.WriteLine($"Измененная строка:{text}");

StringBuilder stringBuilder1 = new StringBuilder(text);
StringBuilder stringBuilder2 = new StringBuilder(text);

for (int i = 0; i < stringBuilder1.Length; i++)
    stringBuilder1[i]= char.ToLower(stringBuilder1[i]);
Console.WriteLine($"Текст в нижнем регистре:{stringBuilder1}");

for (int i = 0;i < stringBuilder1.Length;i++)
    stringBuilder1[i] = char.ToUpper(stringBuilder1[i]);
Console.WriteLine($"Текст в верхнем регистре:{stringBuilder1}");

for (int i = 0; i<stringBuilder2.Length;i++)
{
    if (char.IsLower(stringBuilder2[i]))
        stringBuilder2[i] = char.ToUpper(stringBuilder2[i]);
    else
        stringBuilder2[i] = char.ToLower(stringBuilder2[i]);
}


