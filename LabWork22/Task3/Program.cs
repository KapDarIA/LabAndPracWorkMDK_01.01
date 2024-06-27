
static async Task WriteFileAsync(string fileName, int n)
{
    Console.WriteLine($"Запись в файл {fileName} начата");

    Random random = new();

    using (StreamWriter writer = new(fileName, false))
    {
        for (int i = 1; i < n; i++)
        {
            var text = $"Число№{i}:{random.Next(0, 1000)}";
            await writer.WriteLineAsync(text); // асинхронная запись в файл
        }
    }
    Console.WriteLine("Запись в файл закончена");
}
string fileName = Path.Combine(Environment.CurrentDirectory, "MyNumbers", "1.txt");
await WriteFileAsync(fileName, 1000000);