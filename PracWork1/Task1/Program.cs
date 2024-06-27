Console.Write("Введите имя файла:");
string fileName = Console.ReadLine();

if (File.Exists(fileName))
{
    Console.WriteLine($"Содержимое файла:");
    Console.WriteLine(File.ReadAllText(fileName));
}
else
    Console.WriteLine($"папка {fileName} не существует");
//C:\temp\ispp21\МДК 01.01