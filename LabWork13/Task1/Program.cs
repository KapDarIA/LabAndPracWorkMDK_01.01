int quantity = 0;

Console.Write("Введите строку: ");
string text = Console.ReadLine();
Console.WriteLine($"Количество символов в данной строке: {text.Length}");

for (int i = 0; i < text.Length; i++)
{
    if (Char.IsLetter(text[i]))
        quantity++;
}

Console.WriteLine($"Количество символов без учёта пробелов: {text.Replace(" ", "").Length}");
Console.WriteLine($"Количество букв во введенной пользователем строке: {quantity}");
Console.Write("Введите символ для поиска: ");
char symbol = Convert.ToChar(Console.ReadLine());

for (int i = 0; i < text.Length; i++)
    if (text[i] == symbol)
        Console.WriteLine($"Искомый символ находится на позиции {i + 1}");
if (!text.Contains(symbol))
    Console.WriteLine("Символ не найден в данной строке");