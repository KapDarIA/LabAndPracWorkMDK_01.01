using System.Text.RegularExpressions;

Console.Write("Введите строку:");
string text=Console.ReadLine();
Regex regex = new Regex(@"\s{2,}");
text = regex.Replace(text, @" ").Trim();
Console.WriteLine($"Измененный код:{text}");