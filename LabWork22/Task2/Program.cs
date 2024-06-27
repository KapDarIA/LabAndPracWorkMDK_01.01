static double GetPower(double a, int x)
{
    double result = 1;
    for (int i = 0; i < x; i++)
        result *= a;
    return result;
}

static double GetFormula(int x1, int x2, int x3, int x4, double a1, double a2, double a3, double a4)
{
    double formulaResult = (GetPower(a1, x1) + GetPower(a2, x2)) / (GetPower(a3, x3) - GetPower(a4, x4));
    return formulaResult;
}

Console.WriteLine("Параллельный вызов + результаты");
Task<double> task1 = Task.Run(() => GetPower(3, 2));
Task<double> task2 = Task.Run(() => GetPower(3, 3));
Task<double> task3 = Task.Run(() => GetPower(3, 4));
var results = await Task.WhenAll(task1, task2, task3);
foreach (var result in results)
    Console.WriteLine(result);

Console.WriteLine(GetFormula(8, 7, 6, 5, 4, 3, 2, 1));