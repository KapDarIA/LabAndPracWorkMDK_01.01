using System.Text.RegularExpressions;

Console.Write("Введите свой e-mail:");
string email = Console.ReadLine(); //ri-k_i@gugu.pop.yw.ru
string pattern = @"(\w+|-)\@\w+((\.\w+){1,})\.[a-z]+";
Regex regex = new(pattern);
Match match = regex.Match(email);
if (!match.Success)
    Console.WriteLine("e-mail введен некорректно");
else Console.WriteLine("e-mail введен правильно");