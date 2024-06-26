List<string> valutes = new List<string>() { "euro", "ruble", "dollar" };
Console.Write("Введите количество валют, которые хотите добавить:");
int valutesCount = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < valutesCount; i++)
{
    valutes.Add(Console.ReadLine());
}

Console.WriteLine();

for (int i = 0; i < valutes.Count; i++)
{
    Console.WriteLine($"{i + 1}-{valutes[i]}");
}

Console.WriteLine();

Console.WriteLine("Введите первую и вторую позиции:");
int position1 = Convert.ToInt32(Console.ReadLine()) - 1;
int position2 = Convert.ToInt32(Console.ReadLine()) - 1;

if (position1 < 0 || position2 > valutes.Count - 1)
{
    Console.WriteLine("некорректныне данные");
}
else
{
    for (int i = position1; i <= position2; i++)
    {
        Console.WriteLine($"Номер:{i + 1}-{valutes[i]}");
    }
}


