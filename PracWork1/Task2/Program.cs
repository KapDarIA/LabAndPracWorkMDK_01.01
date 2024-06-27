Console.Write("Введите имя файла:");
string fileName = Console.ReadLine();


if (File.Exists(fileName))
    Console.WriteLine("Файл открыт на дозапись");
else
{
    File.Create(fileName);
    File.Move(fileName, "ПроверкаЗадания2");
    Console.WriteLine($"Файл {fileName} создан и открыт на дозапись");
}
var text = Console.ReadLine();
File.AppendAllText(fileName, text);
