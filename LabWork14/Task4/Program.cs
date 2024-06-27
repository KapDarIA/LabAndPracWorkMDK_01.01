using System.Text.RegularExpressions;

string password;
Console.Write("Введите пароль:");
password = Console.ReadLine(); //12dd?wd3.GHY!hh
string pattern = @"[a-z]&[A-Z]&/d&[.,!?]";
Regex regex = new(pattern);
Match match = regex.Match(password);
if (password.Length < 6 || !match.Success)
    Console.WriteLine("Некорректный пароль!");
