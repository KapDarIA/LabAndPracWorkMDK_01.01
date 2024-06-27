static void GetPower(double a, int x)
{
    double result = 1;
    for (int i = 0; i < x; i++)
        result *= a;
    Console.WriteLine($"{a}^{x}={result}");
}

Console.WriteLine("Последовательный вызов");
await Task.Run(() => GetPower(2, 2));
await Task.Run(() => GetPower(1.5, 3));
await Task.Run(() => GetPower(-2, 3));

Console.WriteLine("Параллельный вызов");
Task task1 = Task.Run(() => GetPower(3, 2));
Task task2 = Task.Run(() => GetPower(3, 3));
Task task3 = Task.Run(() => GetPower(3, 4));
await Task.WhenAll(task1, task2, task3);