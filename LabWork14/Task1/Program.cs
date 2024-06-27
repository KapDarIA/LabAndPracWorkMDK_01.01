using System.Text.RegularExpressions;

Console.Write("Введите номер телефона:");
string phoneNumber = Console.ReadLine(); //+7-912-345-67-89
string pattern1 = @"\+7|8((-\d{3}){2})((-\d{2}){2})";
Regex regex = new(pattern1);
Match match = regex.Match(phoneNumber);
if (!match.Success)
    Console.WriteLine("Некорректный номер телефона");
else
    Console.WriteLine("Номер телефона введен верно");