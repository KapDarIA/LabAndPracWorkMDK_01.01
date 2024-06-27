Console.Write("Введите имя текстового файла:");
var path = Console.ReadLine();
DirectoryInfo directory = new(path);
Console.Write("Введите текст для поиска:");
string text = Console.ReadLine();

if (directory.Exists)
{
    var lines = File.ReadAllLines(path);
    foreach (var line in lines)
        if (line == text)
            Console.WriteLine(line);
}
else
    Console.WriteLine("Файл не найден");